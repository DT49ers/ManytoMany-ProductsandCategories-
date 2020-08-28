using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCategories.Models
{
    
    [NotMapped]
    public class CategoryPage
    {
        // Category to be displayed
        public Category Category { get; set; }

        // UnrelatedProducts to be displayed
        public List<Product> UnrelatedProducts { get; set; }

        // NewRelationship for the <form> submission
        public ProductCategory NewRelationship { get; set; } = new ProductCategory();
    }
}