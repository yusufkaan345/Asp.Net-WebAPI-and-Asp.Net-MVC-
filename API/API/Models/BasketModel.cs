using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class BasketModel
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

     

    

