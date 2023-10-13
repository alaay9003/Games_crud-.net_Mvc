using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Services
{
    public class CategortServies : ICategortServies
    {
        private readonly ApplicationDbContext _context;
        public CategortServies(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Categories.
                Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()
                .ToList();
        }
    }
}
