using Games_Mvc.Models;
using Games_Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Games_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameServies _GameServies;
        public HomeController(IGameServies gameServies)
        {
            _GameServies = gameServies;
        }

        public IActionResult Index()
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