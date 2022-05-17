using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EventGo.Models;
using EventGo.ViewModels;
using EventGo.Database;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace EventGo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext appDbContext;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Name = model.Name,Address = model.Address, Email = model.Email, UserName = model.UserName };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (model.IsOrganizer)
                    {
                        var role = await roleManager.FindByIdAsync("3");
                        await userManager.AddToRoleAsync(user, role.Name);
                    }
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var s in result.Errors)
                    {
                        ModelState.AddModelError(s.Code, s.Description);
                    }
                }
            }
            return View(model);

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Данные введены некорректно!");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> MyProfile()
        {
            User model = await userManager.GetUserAsync(User);
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult MakeDeposit()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult MakeDeposit(AccountDeposit deposit)
        {
            if (ModelState.IsValid)
            {
                if (deposit.DepositAmount <= 0 && deposit.DepositAmount >= 100000 && deposit==null)
                {
                    ModelState.AddModelError(string.Empty, "Размер депозита должен быть не меньше 10 и не больше 100 000 рублей");
                    return View();
                }
                var user = appDbContext.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
                user.Balance += (decimal)deposit.DepositAmount;
                appDbContext.SaveChanges();
                return RedirectToAction("MyProfile", "Account");
            }
            return View(deposit);
        }
        [Authorize]
        [HttpGet]
        public IActionResult CashOut()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult CashOut(AccountCashOut cashOutModel)
        {
            if (ModelState.IsValid)
            {
                
                var user = appDbContext.Users.FirstOrDefault(u => u.Id == userManager.GetUserId(User));
                if (cashOutModel.CashOutAmount <= 0 && cashOutModel.CashOutAmount > user.Balance && cashOutModel.CashOutAmount==null)
                {
                    ModelState.AddModelError(string.Empty, "Сумма вывода должна быть больше 0 и не больше текущего баланса");
                    return View();
                }
                user.Balance -= (decimal)cashOutModel.CashOutAmount;
                appDbContext.SaveChanges();
                return RedirectToAction("MyProfile", "Account");
            }
            return View(cashOutModel);
        }
    }
}
