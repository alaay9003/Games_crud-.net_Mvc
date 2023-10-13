using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Services
{
    public interface IDevicesServies
    {
        IEnumerable<SelectListItem> GetSelectList();

    }
}
