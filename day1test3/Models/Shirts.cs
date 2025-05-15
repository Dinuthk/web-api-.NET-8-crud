using day1test3.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace day1test3.Models
{
    public class Shirts
    {
        public int ShirtId { get; set; }
        [Required]
        public String? Brand { get; set; } //It's OK if Brand is null. 
        [Required]
        public string? Color { get; set; }
        [Shirt_EnsureCorrectSizing]
        public int size { get; set; }
        [Required]
        public string? Gender { get; set; }
        public double? Price { get; set; }

    }
}
