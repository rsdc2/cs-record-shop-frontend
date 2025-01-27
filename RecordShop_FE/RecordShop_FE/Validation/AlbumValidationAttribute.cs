using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace RecordShop_FE
{
    public class AlbumValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Cannot enter an empty value");
            }

            if (value is string str)
            {
                if (str == "")
                {
                    return new ValidationResult("Cannot enter an empty value");
                }
            }

            return ValidationResult.Success;
        }
    }
}
