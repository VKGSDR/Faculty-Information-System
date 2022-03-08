using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class WorkHistory
    {
        public int WorkHistoryId { get; set; }
        public int FacultyId { get; set; }
        public string Organization { get; set; }
        public string JobTitle { get; set; }
        public DateTime JobBeginDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string JobResponsibilities { get; set; }
        public string JobType { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
