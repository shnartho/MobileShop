using System.ComponentModel.DataAnnotations;

namespace MobileShop.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductType { get; set; }
    }
}
