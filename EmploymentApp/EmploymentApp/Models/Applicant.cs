using EmploymentAppMaster.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmploymentApp.Models.Models
{
    public class Applicant
    {

        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Please enter street address")]
        public string AddressStreet { get; set; }//changed address types to multiple fields

        [Required(ErrorMessage = "Please enter address city")]
        public string AddressCity { get; set; }

        [Required(ErrorMessage = "Please enter address state")]
        public string AddressState { get; set; }

        [Required(ErrorMessage = "Please enter address zip code")]
        public string AddressZip { get; set; }

        [Required(ErrorMessage = "Please enter years lived at address")]
        public int AddressYears { get; set; }

        [Required(ErrorMessage = "Please enter social security number")]
        public string SSN { get; set; }

        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [LegalAge]
        public DateTime DateofBirth { get; set; }//changed legal age from boolean to date type with age validation

        [Required(ErrorMessage = "Please enter position applied for")]
        public string PositionApplied { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please enter email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


    }
}