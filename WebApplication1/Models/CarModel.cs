using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Brand { get; set; }
        [Required]
        public Int16 Price { get; set; }

    }
}
