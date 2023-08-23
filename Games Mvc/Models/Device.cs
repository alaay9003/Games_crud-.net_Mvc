using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Models
{
    public class Device : BaseEntity
    {
        [MaxLength(50)]
        public string Icon { get; set; }
        public ICollection<GameDevice> Devices{ get; set; } = new List<GameDevice>();
    }
}
