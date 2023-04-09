using ManagerCakeOk.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ManagerCakeOk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PartialSibarMenu()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult PartialHeaderMenu()
        {
            return PartialView();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            if ((username == "Admin@gmail.com") && (password == "Admin"))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                // TODO: result about request url
                //var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");

                //var url = location.AbsoluteUri;
                //var data = Request.QueryString;
                //if (Request.QueryString.ToString() == "{?ReturnUrl=%2F}")
                //{
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    return Redirect(url);
                //}
                return RedirectToAction("Index", "Home");

                
            }
            else
                return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}