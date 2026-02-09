using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeorgeShop.Models
{
    public class Category
    {
        public int Id { get; set; }


        [Column("varchar(50)")]
        [Required]

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
