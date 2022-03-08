using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class CourseTaught
    {
        public int CourseTaughtId { get; set; }
        public int CourseId { get; set; }
        public int FacultyId { get; set; }
        public int SubjectId { get; set; }
        public DateTime? FirstDateTaught { get; set; }

        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
