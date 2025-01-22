using argeson.Dto;
using argeson.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace argeson.Controllers
{
    [Authorize]

    public class MyAccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public MyAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.FirstName = values.FirstName;
            appUserEditDto.LastName = values.LastName;
      
            appUserEditDto.Email = values.Email;
            return View(appUserEditDto);
        }
        [HttpPost]
        public async Task<ActionResult> Index(AppUserEditDto appUserEditDto)
        {
            //burda if vardı ama ben kullanmadım
                var user = await _userManager.FindByEmailAsync(appUserEditDto.Email);
                user.FirstName = appUserEditDto.FirstName;
                user.LastName = appUserEditDto.LastName;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "MyAccount");
                }
            

            return View();
        }
    }
}