namespace Games_Mvc.Models
{
    public class Category : BaseEntity
    {
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
