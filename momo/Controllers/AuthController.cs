using BLL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Models.Auth;
using System.Security.Claims;
using MODEL.Client;

namespace App.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserAuthVM model)
        {
            ClientService clientService = new ClientService();
            var us = clientService.VerifierCompte(model);

            if (us != null)
            {
                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.Email, us.AdresseMail),

                    new Claim(ClaimTypes.Name, us.Nom),
                    new Claim(ClaimTypes.NameIdentifier, us.Id.ToString()),

                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {

                    AllowRefresh = true,

                };

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }



            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
