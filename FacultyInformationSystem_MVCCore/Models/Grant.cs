using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Grant
    {
        public int GrantId { get; set; }
        public int? FacultyId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[0-9\.\-\/\,\(\)]*[a-zA-Z\,\/]+[\s\.\-\/\,\(\)]*[0-9]*[\s\.\-\/\(\)]*[a-zA-Z0-9\s\/\(\)]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Grant Title"), MaxLength(50)]
        [Display(Name = "Grant Title")]
        public string GrantTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [RegularExpression(@"^[0-9\.\-\/\,\(\)]*[a-zA-Z\,\/]+[\s\.\-\/\,\(\)]*[0-9]*[\s\.\-\/\(\)]*[a-zA-Z0-9\s\/\(\)]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Grant Description"), MaxLength(50)]
        [Display(Name = "Grant Description")]
        public string GrantDescription { get; set; }

        //public virtual Faculty Faculty { get; set; }
    }
}
