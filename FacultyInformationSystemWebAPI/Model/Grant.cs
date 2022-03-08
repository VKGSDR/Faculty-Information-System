using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class Grant
    {
        public int GrantId { get; set; }
        public int? FacultyId { get; set; }
        public string GrantTitle { get; set; }
        public string GrantDescription { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
