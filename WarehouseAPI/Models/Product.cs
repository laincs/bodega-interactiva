using WarehouseAPI.Models.Base;

namespace WarehouseAPI.Models
{
    public class Product : BaseEntity
    {
        public string Title  { get; set; } = string.Empty;
        public int Volume { get; set; }

        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}