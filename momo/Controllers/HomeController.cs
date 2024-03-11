using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using momo.Models;
using System.Diagnostics;

namespace App.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CategoryService service = new CategoryService();
            return View(service.List());
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
