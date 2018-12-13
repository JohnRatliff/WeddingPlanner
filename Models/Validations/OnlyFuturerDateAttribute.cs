using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeddingPlanner.Models
{
    public class OnlyFutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(((DateTime)value).Date <= DateTime.Now.Date)
            {
                return new ValidationResult("Date must be in the future!");
            }
            return ValidationResult.Success;
        }
    }
}