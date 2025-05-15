using System.ComponentModel.DataAnnotations;

namespace day1test3.Models.Validations
{
    public class Shirt_EnsureCorrectSizingAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirts;

            if(shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender))
            {
                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.size<8) { 
                    return new ValidationResult("For men's shirts, the size.......... greater or eq 8");
                }
                else if(shirt.Gender.Equals("women",StringComparison.OrdinalIgnoreCase)&& shirt.size < 6){
                    return new ValidationResult("women ces");
                }
            }

            return ValidationResult.Success;
        }
    }
}
