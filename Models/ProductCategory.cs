using System;

namespace ProductsCategories.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Foreign Keys
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        // Navigation Properties (not added to DB - must use .Include to get data)
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}