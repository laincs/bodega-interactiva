namespace WarehouseAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title  { get; set; } = string.Empty;
        public int Volume { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }


        public decimal Price { get; set; }
    }
}