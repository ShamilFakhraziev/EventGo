using EventGo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGo.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AdminController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            List<User> organizers = new List<User>();
            foreach (var u in userManager.Users.ToList())
            {
                var isOrg = await userManager.IsInRoleAsync(u, "organizer");
                if (isOrg)
                {
                    organizers.Add(u);
                }
            }
            return View(organizers);
        }
        public async Task<IActionResult> AllUnconfimedOrganizers()
        {
            List<User> unOrgs = new List<User>();
            foreach (var u in userManager.Users.ToList())
            {
                var isUnOrg = await userManager.IsInRoleAsync(u, "unconfirmed organizer");
                if (isUnOrg)
                {
                    unOrgs.Add(u);
                }
            }
            return View(unOrgs);
        }
        [HttpPost]
        public async Task<IActionResult> AddOrganizer(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var role = await roleManager.FindByNameAsync("organizer");
            await userManager.RemoveFromRoleAsync(user, "unconfirmed organizer");
            await userManager.AddToRoleAsync(user, role.Name);
            return RedirectToAction("AllUnconfimedOrganizers", "Admin");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "organizer");
            return RedirectToAction("Index", "Admin");
        }
    }
}
