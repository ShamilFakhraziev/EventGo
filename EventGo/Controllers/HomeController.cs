using EventGo.Database;
using EventGo.Models;
using EventGo.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<User> userManager;
        public HomeController(AppDbContext dbContext, UserManager<User> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            List<DisplayEvent> events = new List<DisplayEvent>();
            foreach(var e in dbContext.Events.ToList())
            {
                if(e.NumberOfSeats > 0)
                events.Add(new DisplayEvent { Event = e, User = dbContext.Users.FirstOrDefault(u=>u.Id==e.UserId)});
            }
            return View(events);
        }  
    }
}
