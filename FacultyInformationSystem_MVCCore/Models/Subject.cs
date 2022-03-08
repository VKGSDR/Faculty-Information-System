using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class Subject
    {
        //public Subject()
        //{
        //    CourseSubjects = new HashSet<CourseSubject>();
        //    CourseTaughts = new HashSet<CourseTaught>();
        //}

        public int SubjectId { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+[\s\.\-]*[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters Value Only")]
        [Required(ErrorMessage = "Please Enter Subject Name"), MaxLength(30)]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        //public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        //public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
    }
}
