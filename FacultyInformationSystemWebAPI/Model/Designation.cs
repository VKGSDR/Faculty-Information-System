using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Designation
    {
        public Designation()
        {
            Faculties = new HashSet<Faculty>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
