using System.ComponentModel.DataAnnotations;

namespace BadmintonOutlet.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}