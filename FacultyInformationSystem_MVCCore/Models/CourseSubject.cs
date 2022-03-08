using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class CourseSubject
    {
        public int CourseSubjectId { get; set; }
        public int CourseId { get; set; }
        public int SubjectId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
