using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace GeorgeShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MinLength(3)]
        [MaxLength(10)]
        public string Name { get; set; }
        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }

        public string? Image {  get; set; }
        [Display(Name="Categories")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
