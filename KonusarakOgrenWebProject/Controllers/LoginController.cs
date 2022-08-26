using EntityLayer.Concrete;
using KonusarakOgrenWebProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace KonusarakOgrenWebProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager; 
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel registerModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerModel.Name,
                Surname = registerModel.Surname,
                Email = registerModel.Mail,
                UserName = registerModel.UserName,
                Gender=registerModel.Gender
            };
            if (registerModel.Password == registerModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, registerModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerModel);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel signInViewModel) 
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(signInViewModel.UserName, signInViewModel.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    var user = await _userManager.FindByNameAsync(signInViewModel.UserName);
                    if(user==null)
                    {
                        ViewBag.Message = String.Format("Yanlış Kullanıcı adı");                      
                        //ModelState.AddModelError(string.Empty, "Yanlış kullanıcı adı");
                        return View();
                    }
                    else if(!await _userManager.CheckPasswordAsync(user,signInViewModel.Password))
                    {
                        ViewBag.Message = String.Format("Yanlış parola");                       
                        //ModelState.AddModelError(string.Empty, "Yanlış parola");
                        return View();

                    }

                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
