using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class WorkHistory
    {
        public int WorkHistoryId { get; set; }
        public int FacultyId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Organization Name"), MaxLength(50)]
        [Display(Name = "Organization Name")]
        public string Organization { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Job Title"), MaxLength(50)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter Job Begin Date")]
        [Display(Name = "Job Begin Date")]
        public DateTime JobBeginDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Job End date")]
        [Display(Name = "Job End Date")]
        public DateTime? JobEndDate { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Job Responsibilities"), MaxLength(50)]
        [Display(Name = "Job Responsibilities")]
        public string JobResponsibilities { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Job Type"), MaxLength(50)]
        [Display(Name = "Job Type")]
        public string JobType { get; set; }

        //public virtual Faculty Faculty { get; set; }
    }
}
