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

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Date Available to Work")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

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

        [Display(Name = "Desired Salary")]
        public decimal DesiredSalary { get; set; } //Changed from Double to Decimal

        [Display(Name = "Emergency Contact First Name")]
        public string EmergencyFirstName { get; set; }

        [Display(Name = "Emergency Contact Middle Name")]
        public string EmergencyMiddleName { get; set; }

        [Display(Name = "Emergency Contact Last Name")]
        public string EmergencyLastName { get; set; }

        [Display(Name = "Emergency Address")]
        public string EmergencyAddressStreet { get; set; }

        [Display(Name = "Emergency City")]
        public string EmergencyAddressCity { get; set; }

        [Display(Name = "Emergency State")]
        public string EmergencyAddressState { get; set; }

        [Display(Name = "Emergency Zip")]
        public string EmergencyAddressZip { get; set; }

        [Display(Name = "Emergency Phone")]
        [Phone]
        public string EmergencyPhoneNumber { get; set; }

        [Display(Name = "Emergency Email address")]
        [EmailAddress]
        public string EmergencyEmail { get; set; }

        [Display(Name = "Emergency Relationship")]
        public string EmergencyRelationship { get; set; }

        [Display(Name = "Medical History")]
        public string[] MedicalHistory { get; set; }

        [Display(Name = "Race")]
        [Required(ErrorMessage = "Please enter your race")]
        public string[] Race { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please enter your gender")]
        public string[] Gender { get; set; }

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

        [Display(Name = "If so, what?")]
        public string CrimeType { get; set; }

        [Display(Name = "Reference email")]
        public string References { get; set; }

        [Display(Name = "Do you have a driver's license?")]
        public bool DriversLicense { get; set; }

        [Display(Name = "Driver's license #")]
        public string DLNum { get; set; }

        [Display(Name = "Driver's license Issue Date")]
        public string DLIssueState { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Driver's license expires:")]
        [DataType(DataType.Date)]
        public DateTime DLExpireDate { get; set; }

        [Display(Name = "Did you serve in the military?")]
        public bool MilitaryService { get; set; }

        [Display(Name = "Where you honorably discharged?")]
        public bool MilitaryDischarge { get; set; }

        [Display(Name = "Years Served")]
        public int YearServed { get; set; }

        [Display(Name = "Military Branch (Army, Marines, Navy, Air Force, Coast Guard)")]
        public string MilitaryBranch { get; set; }

        [Display(Name = "Traffic Accidents in the past 3 years?")]
        public int TrafficAccident { get; set; }

        [Display(Name = "Traffic Violations in the past 3 years?")]
        public int TrafficViolation { get; set; }

        [Display(Name = "Were you stopped for suspicion of drinking and driving?")]
        public bool DrinkAndDrive { get; set; }
        
        [Display(Name = "Were you stopped for suspicion of distracted driving?")]
        public bool DistractedDrive { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string ReferencePhoneNumber { get; set; }

        [Display(Name = "Employer Name")]
        public string EmployerName{ get; set; }

        [Display(Name = "Employer City")]
        public string EmployerCity { get; set; }

        [Display(Name = "State")]
        public string EmployerState { get; set; }

        [Display(Name = "Zip")]
        public string EmployerZip { get; set; }

        [Display(Name = "Phone")]
        [Phone]
        [Required(ErrorMessage = "Please enter a phone number")]
        public string EmployerNumber { get; set; }

        [Display(Name = "Employer Email address")]
        [EmailAddress]
        public string EmployerEmail { get; set; }

        [Display(Name = "Supervisor Name")]
        public string SupervisorName { get; set; }

        [Display(Name = "Last Job Title")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Employment start date:")]
        [DataType(DataType.Date)]
        public DateTime EmploymentDateFrom { get; set; }
        
        [Required(ErrorMessage = "Please choose date.")]
        [Display(Name = "Employment end date:")]
        [DataType(DataType.Date)]
        public DateTime EmploymentDateTo { get; set; }

        //noah there above are employer and your data fields are employer they should be put into the 
        //appropriate location in the view

        [Display(Name = "Have any children?")]
        public bool HasChildren { get; set; }

        [Display(Name = "How many children?")]
        public int NumOfChildren { get; set; }

        //Days of work missed due to a child's illness/out of school?
        [Display(Name = "Past month?")]
        public int WorkMissedPastMonth { get; set; }

        [Display(Name = "Past six months?")]
        public int WorkMissedPastSixMonths { get; set; }

        [Display(Name = "Past year?")]
        public int WorkMissedPastYear { get; set; }

        // Do you currently have health insurance?
        // Changed from string to seperate boolean fields for yourself/spouse/children.

        [Display(Name = "Yourself")]
        public bool HaveHealthInsuranceYourself { get; set; }

        [Display(Name = "Spouse")]
        public bool HaveHealthInsuranceSpouse { get; set; }

        [Display(Name = "Children")]
        public bool HaveHealthInsuranceChildren { get; set; }
    }
}