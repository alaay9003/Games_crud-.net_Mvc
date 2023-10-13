
using Games_Mvc.Models;
using Games_Mvc.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategortServies _categoryService;
        private readonly IDevicesServies _deviceService;
        private readonly IGameServies _GameServies;

        public GameController(ApplicationDbContext context, ICategortServies categoryService,
            IDevicesServies deviceService, IGameServies gameServies)
        {
            _context = context;
            _categoryService = categoryService;
            _deviceService = deviceService;
            _GameServies = gameServies;
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
                Categories = _categoryService.GetSelectList(),
                Devieces = _deviceService.GetSelectList(),
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameViewModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Categories = _categoryService.GetSelectList();
                model.Devieces = _deviceService.GetSelectList();
                return View(model);
            }
            await _GameServies.Create(model);
            return RedirectToAction(nameof(Index)); 
            
        }
    }
}
