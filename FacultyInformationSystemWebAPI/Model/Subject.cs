using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Subject
    {
        public Subject()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            CourseTaughts = new HashSet<CourseTaught>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
    }
}
