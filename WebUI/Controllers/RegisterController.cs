using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                if (registerModel.Password==registerModel.PasswordRepeat)
                {

                    registerModel.AppUser.JoinDate= DateTime.Now;   

                    var result = await _userManager.CreateAsync(registerModel.AppUser,registerModel.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");

                    }
                    else
                    {
                        return View(registerModel);
                    }

                }
            }
            return View(registerModel);

        }
    }
}

