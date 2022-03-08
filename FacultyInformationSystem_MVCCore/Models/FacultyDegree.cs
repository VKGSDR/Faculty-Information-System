using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystem_MVCCore
{
    public partial class FacultyDegree
    {
        public int DegreeId { get; set; }
        public int? FacultyId { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public int DegreeYear { get; set; }
        public string Grade { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
