using EmploymentAppMaster.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmploymentApp.Models.Models
{
    public class Applicant
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Today's Date")]
        [DataType(DataType.Date)]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter street address")]
        public string AddressStreet { get; set; }//changed address types to multiple fields

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter address city")]
        public string AddressCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter address state")]
        public string AddressState { get; set; }

        [Display(Name = "Zip")]
        [Required(ErrorMessage = "Please enter address zip code")]
        public string AddressZip { get; set; }

        [Display(Name = "Years lived at address")]
        [Required(ErrorMessage = "Please enter years lived at address")]
        public int AddressYears { get; set; }

        [Display(Name = "Social Security")]
        [Required(ErrorMessage = "Please enter social security number")]
        public string SSN { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [LegalAge]
        public DateTime DateofBirth { get; set; }//changed legal age from boolean to date type with age validation

        [Display(Name = "Position applying for")]
        [Required(ErrorMessage = "Please enter position applied for")]
        public string PositionApplied { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please enter email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Days available to work")]
        public string DaysAvailable { get; set; }

        [Display(Name = "Employment Desired (Full-time, Part-time)")]
        public string DesiredEmployment { get; set; }

        [Display(Name = "Hours weekly able to work")]
        public int HoursAvailable { get; set; }

        [Display(Name = "Work Nights?")]
        public bool WorkNights { get; set; }

        [Display(Name = "Have you previously been fired?")]
        public bool FiredBefore { get; set; }

        [Display(Name = "Convicted of a crime?")]
        public bool CrimeBefore { get; set; }

        [Display(Name = "Date convicted of a crime?")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter address city")]
        [CustomAdmissionDate(ErrorMessage = "Date must be less than or equal to Today's Date.")]
        public DateTime CrimeDate { get; set; }

        [Display(Name = "If so, what?")]
        public string CrimeType { get; set; }

        [Display(Name = "References (email)")]
        public string References { get; set; }

        [Display(Name = "References (Name, Title, Company, Address)")]
        public string ReferencesEmployers { get; set; }

        [Display(Name = "Do you have a driver's license?")]
        public bool DriversLicense { get; set; }

        [Display(Name = "Currently own a vehicle?")]
        public bool OwnCar { get; set; }

        [Display(Name = "Own Insurance?")]
        public bool Insurance { get; set; }

        [Display(Name = "Make/Model/Year ")]
        public string MakeModelYear { get; set; }

        [Display(Name = "Driver's license #")]
        public string DLNum { get; set; }

        [Display(Name = "Willing to Drive a personal vehicle?")]
        public bool PersonalVehicle { get; set; }

        [Display(Name = "School Name/City/Major, Degree, Certificate ")]
        public string Credentials { get; set; }

        [Display(Name = "Graduation Date")]
        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }


        [Display(Name = "Duties Performed, Skills Used, etc")]
        public string Tasks { get; set; }
        
        [Display(Name = "Contact Employer")]
        public bool ContactEmployer { get; set; }

        [Display(Name = "Current Marital Status")]
        public string MaritalStatus { get; set; }


        [Display(Name = "Salary")]
        public double Salary { get; set; }
        
    }
}