using Games_Mvc.Attributes;
using Games_Mvc.Setting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Models
{
    public class CreateGameViewModel
    {
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
        [Display(Name="Category")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevices { get; set; } = default!;
        public IEnumerable<SelectListItem> Devieces { get; set; } = Enumerable.Empty<SelectListItem>();

        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)]
        [AllowedExtentions(FileSettings.AllowedExtensions),AllowedSize(FileSettings.MaxFileSizeB)]
        public List<IFormFile> Cover { get; set; } = default!;
    }
}
