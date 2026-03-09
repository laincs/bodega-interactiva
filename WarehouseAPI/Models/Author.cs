using WarehouseAPI.Models.Base;

namespace WarehouseAPI.Models
{
    public class Author : BaseEntity
    {
        public int Id;
        public string Name = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}