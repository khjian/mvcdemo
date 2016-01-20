using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class FirstNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name shoud not contain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}