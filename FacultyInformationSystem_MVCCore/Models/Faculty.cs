using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;

//#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Faculty
    {
        //public Faculty()
        //{
        //    CourseTaughts = new HashSet<CourseTaught>();
        //    FacultyDegrees = new HashSet<FacultyDegree>();
        //    Grants = new HashSet<Grant>();
        //    Publications = new HashSet<Publication>();
        //    WorkHistories = new HashSet<WorkHistory>();
        //}

        public int FacultyId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter First Name"), MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Last Name"), MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.MultilineText)]
        [RegularExpression(@"^[0-9\.\-\/\,\(\)]*[a-zA-Z\,\/]+[\s\.\-\/\,\(\)]*[0-9]*[\s\.\-\/\(\)]*[a-zA-Z0-9\s\/\(\)]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Faculty Address"), MaxLength(50)]
        [Display(Name = "Address")]
        public string FacultyAddress { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter City Name"), MaxLength(30)]
        [Display(Name = "City")]
        public string City { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Faculty's State Name"), MaxLength(30)]
        [Display(Name = "State")]
        public string FacultyState { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Pin Code")]
        [RegularExpression(@"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}$", ErrorMessage = "Please Enter Valid Pin Code")]
        [Display(Name = "Zip Code")]
        public int Pincode { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[Required(ErrorMessage = "Please Enter Mobile Number"), MaxLength(10)]
        //[Range(maximum: 9999999999, minimum: 1000000000, ErrorMessage = "Please Enter Valid Mobile Number")]
        [Display(Name = "Mobile Number")]
        public string? MobileNo { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter Hire Date")]
        [Display(Name = "Hire Date")]
        public string HireDate { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-z0-9\-]+\.)+))([a-z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid E-Mail Address ")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        public int? DeptId { get; set; }
        public int? DesignationId { get; set; }
        public string UserName { get; set; }

        //public virtual Department Dept { get; set; }
        //public virtual Designation Designation { get; set; }
        //public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
        //public virtual ICollection<FacultyDegree> FacultyDegrees { get; set; }
        //public virtual ICollection<Grant> Grants { get; set; }
        //public virtual ICollection<Publication> Publications { get; set; }
        //public virtual ICollection<WorkHistory> WorkHistories { get; set; }
    }
}
