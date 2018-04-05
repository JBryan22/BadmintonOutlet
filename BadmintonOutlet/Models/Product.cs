using System.ComponentModel.DataAnnotations;

namespace BadmintonOutlet.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public Brand Brand { get; set; }
        public int BrandID { get; set; }
        public RacquetSeries Series { get; set; }
    }
}