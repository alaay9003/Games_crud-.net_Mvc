using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Services
{
    public class DevicesServies : IDevicesServies
    {
        private readonly ApplicationDbContext _context;
        public DevicesServies(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _context.Devices.
                Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()
                .ToList();
        }
    }
}
