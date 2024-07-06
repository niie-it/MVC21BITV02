
using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    public class EnoughAgeForWorkAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var myDate = (DateTime)value;
                if (myDate.AddYears(16) > DateTime.Now)
                {
                    return new ValidationResult("Chưa đủ 16 tuổi");
                }
            }
            return ValidationResult.Success;
        }
    }
}