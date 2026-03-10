using WarehouseAPI.Models.Base;

namespace WarehouseAPI.Models
{
    public class Publisher : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}