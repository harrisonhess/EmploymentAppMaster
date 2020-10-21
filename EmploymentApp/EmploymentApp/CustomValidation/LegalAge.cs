using EmploymentApp.Models.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmploymentAppMaster.CustomValidation
{
    public class LegalAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var applicant = (Applicant)validationContext.ObjectInstance;

            if (applicant.DateofBirth == null)
                return new ValidationResult("Date of Birth is required.");

            var age = DateTime.Today.Year - applicant.DateofBirth.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Applicant should be at least 18 years old.");
        }
    }
}