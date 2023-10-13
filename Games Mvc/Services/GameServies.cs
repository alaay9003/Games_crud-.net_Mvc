using Games_Mvc.Models;
using Games_Mvc.Setting;

namespace Games_Mvc.Services
{
    public class GameServies :IGameServies
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _ImgPath;
        public GameServies(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _ImgPath = $"{_webHostEnvironment.WebRootPath}{FileSettings.ImagesPath}";
        }

        public async Task Create(CreateGameViewModel model)
        {
            var coverName = $"{Guid.NewGuid()}{Path.GetExtension(model.Cover[0].FileName)}";
            var path = Path.Combine(_ImgPath, coverName);
            using var stream = File.Create(path);
            await model.Cover[0].CopyToAsync(stream);

            Game game = new Game()
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Cover = coverName,
                Device = model.SelectedDevices.Select(d => new GameDevice { DeviceId = d }).ToList(),
            };
            _context.Add(game);
            _context.SaveChanges();

        }
    }
}
