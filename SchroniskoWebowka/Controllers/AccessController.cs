using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using SchroniskoWebowka.Models;
using Microsoft.EntityFrameworkCore;

namespace SchroniskoWebowka.Controllers
{
    public class AccessController : Controller
    {
        private readonly SchroniskoContext _context;
        public AccessController(SchroniskoContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            ClaimsPrincipal calimUser = HttpContext.User;
            if(calimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Login(LoginAut model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var pracownik = await _context.Pracowniks.FirstOrDefaultAsync(x => x.PracownikEmail == model.Email);


            if(pracownik != null)
            {
                var haslo = pracownik.PracownikHaslo;
                haslo = haslo.Replace(" ", string.Empty);
                if (haslo == model.Haslo)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, pracownik.PracownikNazwisko),
                        new Claim(ClaimTypes.Role, "Pracownik"),
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToAction("Index", "Home");
                }
            }

            ViewData["ValidateMessage"] = "Niepoprawny login lub hasło";
            return View();
        }
    }
}
