using CoreShopMvc.Repositories.EntityFramework.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreShopMvc.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Data.Models.Admin admin)
        {

            using Context context = new();
            var result = context.Admins.FirstOrDefault(c => c.UserName == admin.UserName && c.Password == admin.Password);
            if (result != null)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.UserName)
                    };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Product");
            }
            return View();

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}
