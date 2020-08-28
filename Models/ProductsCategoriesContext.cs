using Microsoft.EntityFrameworkCore;

namespace ProductsCategories.Models
{
    public class ProductsCategoriesContext : DbContext
    {
        public ProductsCategoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}