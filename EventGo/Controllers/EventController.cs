using EventGo.Database;
using EventGo.Models;
using EventGo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        private readonly AppDbContext db;
        private readonly IWebHostEnvironment webHost;
        private readonly UserManager<User> userManager;
        public EventController(AppDbContext db, IWebHostEnvironment webHost, UserManager<User> userManager)
        {
            this.webHost = webHost;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Read(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
            var currentEvent = db.Events.FirstOrDefault(e => e.Id == id);
            var isPurchased = db.UserEvents.Where(e => e.UserId == user.Id && e.EventId == id).Count() != 0;
            Event ev = db.Events.FirstOrDefault(e => e.Id == id);
            if(ev == null) return NotFound();
            
            return View(new EventBuyTicket { Event = ev, isPurchased = isPurchased, isThisOrg = ev.UserId == user.Id});
        }

        [Authorize(Roles = "organizer")]
        [HttpGet]
        public IActionResult Create()
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
            ViewBag.UserId = user.Id;
            return View();
        }
        [Authorize(Roles = "organizer")]
        [HttpPost]
        public IActionResult Create(Event ev, IFormFile imagePath)
        {
            if (ev == null) return BadRequest();
                
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
                ViewBag.UserId = user.Id;
                if (imagePath != null)
                {
                    if (imagePath.FileName.EndsWith("jpeg") || imagePath.FileName.EndsWith("jpg")
                        || imagePath.FileName.EndsWith("png"))
                    {
                        ev.Image = imagePath.FileName;
                        using (var stream = new FileStream(Path.Combine(webHost.WebRootPath, "images/", imagePath.FileName), FileMode.Create))
                        {
                            imagePath.CopyTo(stream);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Формат файла должен соответствовать jpg,jpeg или png");
                        return View(ev);
                    }
                }
                db.Events.Add(ev);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(ev);
        }

        
        public IActionResult BuyTicket(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
            var currentEvent = db.Events.FirstOrDefault(e => e.Id == id);
            var isPurchased = db.UserEvents.Where(e => e.UserId == user.Id && e.EventId == id).Count() != 0;
            if(!isPurchased)
            {
                if(user.Balance < currentEvent.Price)
                {
                    return BadRequest("Недостаточно средств");
                }
                else
                {
                    user.Balance -= currentEvent.Price;
                    db.Users.FirstOrDefault(u => u.Id == currentEvent.UserId).Balance += currentEvent.Price;
                    currentEvent.NumberOfSeats -= 1;
                    db.UserEvents.Add(new UserEvent { UserId = user.Id, EventId = currentEvent.Id});
                }   
            }
            db.SaveChanges();
            return Redirect($"/Event/Read/{id}");
        }

        public IActionResult Delete(int id)
        {
            var ev = db.Events.FirstOrDefault(e => e.Id == id);
            if (ev == null) return BadRequest("Ошибка удаления, нет такого мероприятия");

            var org = db.Users.FirstOrDefault(o => o.Id == ev.UserId);

            decimal priceSum = 0;
            List<UserEvent> userEvents = db.UserEvents.Where(ue=>ue.EventId == id).ToList();
            priceSum = userEvents.Count * ev.Price;
            if(org.Balance < priceSum) return BadRequest("Недостаточно баланса для возврата денег за билеты");
            org.Balance -= priceSum;
            foreach (var userEvent in userEvents)
            {
                var user = db.Users.FirstOrDefault(u => u.Id == userEvent.UserId);
                user.Balance += ev.Price;
                db.UserEvents.Remove(userEvent);
            }

            db.Remove(ev);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
