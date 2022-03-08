using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Department
    {
        //public Department()
        //{
        //    Courses = new HashSet<Course>();
        //    Faculties = new HashSet<Faculty>();
        //    //SubjectList = new List<SelectListItem>();
        //}

        public int DeptId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Department Name"), MaxLength(30)]
        [Display(Name = "Department Name")]
        public string DeptName { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }
        //public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
