using argeson.Dto;
using argeson.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace argeson.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

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
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            Random random = new Random();
            int code = 0;
            code = random.Next(10000, 1000000);
            AppUser appuser = new AppUser()
            {
                FirstName = appUserRegisterDto.FirstName,
                LastName = appUserRegisterDto.LastName,
                
                UserName = appUserRegisterDto.UserName,
                Email = appUserRegisterDto.Email,
            
            };
            var result = await _userManager.CreateAsync(appuser, appUserRegisterDto.Password);

            if (result.Succeeded)
            {
                // Başarılı kayıt işleminden sonra yönlendirme yapabilirsiniz
                return RedirectToAction("Index", "Products");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
