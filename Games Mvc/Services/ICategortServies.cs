using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Mvc.Services
{
    public interface ICategortServies
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
