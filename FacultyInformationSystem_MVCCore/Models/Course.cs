using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Course
    {
        //public Course()
        //{
        //    CourseSubjects = new HashSet<CourseSubject>();
        //    CourseTaughts = new HashSet<CourseTaught>();
        //}

        public int CourseId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Course Name"), MaxLength(30)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Range(maximum: 250, minimum: 1, ErrorMessage = "Please Enter Value Between 1 to 250 ")]
        [Required(ErrorMessage = "Please Enter Course Credits")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Please Enter Numeric Value Only")]
        public int CourseCredits { get; set; }

        public int DeptId { get; set; }

        //public virtual Department Dept { get; set; }
        //public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        //public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
    }
}
