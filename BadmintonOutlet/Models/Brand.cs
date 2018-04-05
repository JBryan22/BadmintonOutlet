using System.ComponentModel.DataAnnotations;

namespace BadmintonOutlet.Models
{
    public class Brand
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}