using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Faculty
    {
        public Faculty()
        {
            CourseTaughts = new HashSet<CourseTaught>();
            FacultyDegrees = new HashSet<FacultyDegree>();
            Grants = new HashSet<Grant>();
            Publications = new HashSet<Publication>();
            WorkHistories = new HashSet<WorkHistory>();
        }

        public int FacultyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyAddress { get; set; }
        public string City { get; set; }
        public string FacultyState { get; set; }
        public int Pincode { get; set; }
        public decimal? MobileNo { get; set; }
        public string HireDate { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public int? DeptId { get; set; }
        public int? DesignationId { get; set; }
        public string UserName { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual ICollection<CourseTaught> CourseTaughts { get; set; }
        public virtual ICollection<FacultyDegree> FacultyDegrees { get; set; }
        public virtual ICollection<Grant> Grants { get; set; }
        public virtual ICollection<Publication> Publications { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
    }
}
