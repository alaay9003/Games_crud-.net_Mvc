
using Games_Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GameController(ApplicationDbContext context)
        {
            _context = context;   
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            CreateGameViewModel viewModel = new CreateGameViewModel()
            {
                Categories = _context.Categories.Select(c => new SelectListItem {Value = c.Id.ToString() ,Text = c.Name }).ToList(),
                Devieces = _context.Devices.Select(d => new SelectListItem {  Value = d.Id.ToString() , Text = d.Name }).ToList(),
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(CreateGameViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction(nameof(Index)); 
            
        }
    }
}
