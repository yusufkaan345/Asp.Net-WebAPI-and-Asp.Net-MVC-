using System.ComponentModel.DataAnnotations;

namespace ECommerse.Models
{
  
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public string ProductCategory { get; set; } = "";
        public string ProductImgUrl { get; set; } = "";
        public string ProductFeatures { get; set; } = "";

        public double ProductPrice { get; set; } = 0;
        public int ProductStar { get; set; } = 0;


    }
}
