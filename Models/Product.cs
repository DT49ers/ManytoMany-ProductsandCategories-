using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsCategories.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(1, 3000000, ErrorMessage = "please enter a value that is at least 1.")]
        public decimal? Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Foreign Keys

        // Navigation Properties (not added to DB - must use .Include for to get data)
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
