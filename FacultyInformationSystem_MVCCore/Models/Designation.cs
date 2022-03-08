using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Designation
    {
        //public Designation()
        //{
        //    Faculties = new HashSet<Faculty>();
        //}

        public int DesignationId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Designation Name"), MaxLength(30)]
        [Display(Name = "Designation Name")]
        public string DesignationName { get; set; }

        //public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
