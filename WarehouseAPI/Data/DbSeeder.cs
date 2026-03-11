using WarehouseAPI.Models;

namespace WarehouseAPI.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(WarehouseContext context)
        {
            if (context.Products.Any())
                return;

            var shueisha = new Publisher { Name = "Shueisha" };
            var kodansha = new Publisher { Name = "Kodansha" };

            context.Publishers.AddRange(shueisha, kodansha);

            var oda = new Author { Name = "Eiichiro Oda" };
            var isayama = new Author { Name = "Hajime Isayama" };
            var kishimoto = new Author { Name = "Masashi Kishimoto" };

            context.Authors.AddRange(oda, isayama, kishimoto);

            var shonen = new Category { Name = "Shonen" };
            var action = new Category { Name = "Action" };
            var fantasy = new Category { Name = "Fantasy" };

            context.Categories.AddRange(shonen, action, fantasy);

            await context.SaveChangesAsync();

            var products = new List<Product>
            {
                new Product
                {
                    Title = "One Piece",
                    Volume = 1,
                    Price = 9.99m,
                    AuthorId = oda.Id,
                    PublisherId = shueisha.Id,
                    Description = "Luffy begins his adventure to become Pirate King.",
                    Stock = 20,
                    ISBN = "9784088725093",
                    SKU = "OP-001",
                    ImageUrl = "",
                    Categories = new List<Category> { shonen, action, fantasy }
                },

                new Product
                {
                    Title = "Attack on Titan",
                    Volume = 1,
                    Price = 10.99m,
                    AuthorId = isayama.Id,
                    PublisherId = kodansha.Id,
                    Description = "Humanity fights for survival against the Titans.",
                    Stock = 15,
                    ISBN = "9784063842760",
                    SKU = "AOT-001",
                    ImageUrl = "",
                    Categories = new List<Category> { action, fantasy }
                },

                new Product
                {
                    Title = "Naruto",
                    Volume = 1,
                    Price = 8.99m,
                    AuthorId = kishimoto.Id,
                    PublisherId = shueisha.Id,
                    Description = "A young ninja dreams of becoming Hokage.",
                    Stock = 25,
                    ISBN = "9781569319000",
                    SKU = "NAR-001",
                    ImageUrl = "",
                    Categories = new List<Category> { shonen, action }
                }
            };

            context.Products.AddRange(products);

            await context.SaveChangesAsync();
        }
    }
}