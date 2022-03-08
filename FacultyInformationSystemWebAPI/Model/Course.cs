using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Course
    {
        public Course()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            CourseTaughts = new HashSet<CourseTaught>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
    }
}
