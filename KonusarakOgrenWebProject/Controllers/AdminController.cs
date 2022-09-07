using EntityLayer.Concrete;
using KonusarakOgrenWebProject.Models;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace KonusarakOgrenWebProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        

        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleViewModel roleViewModel)
        {
            AppRole role = new AppRole();
            role.Name=roleViewModel.Name;
            IdentityResult result = await _roleManager.CreateAsync(role);

            if(result.Succeeded)
            {
                return RedirectToAction("Roles");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(roleViewModel);
        }

        public async Task<IActionResult> Roles()
        {
            var result = await _roleManager.Roles.ToListAsync();
            return View(result);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _roleManager.Roles.ToListAsync();
            foreach (var item in result)
            {
                if (item.Id == id)
                {
                    IdentityResult result2= await _roleManager.DeleteAsync(item);
                    if (result2.Succeeded)
                    {
                        return RedirectToAction("Roles");
                    }
                    else
                    {
                        ViewBag.error = "Bir hata meydana geldi";
                    }                  
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            AppRole role =await _roleManager.FindByIdAsync(id);
            if(role!=null)
            {
                return View(role.Adapt<RoleViewModel>());
                
            }
            else
            {
                ViewBag.error2 = "Rol bulunamadı";
                return View("Roles");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Update(RoleViewModel roleViewModel)
        {
            AppRole role=await _roleManager.FindByIdAsync(roleViewModel.Id);
            if (role!=null)
            {
                role.Name = roleViewModel.Name;
                IdentityResult result=await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "GÜncelleme başarısız oldu");
            }

            return View(roleViewModel);        
        }


        public async Task<IActionResult> Users()
        {
            var result = await _userManager.Users.ToListAsync();
            return View(result);
        }
    }
}
