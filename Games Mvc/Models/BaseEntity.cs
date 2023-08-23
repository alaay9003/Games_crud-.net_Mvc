using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;
    }
}
