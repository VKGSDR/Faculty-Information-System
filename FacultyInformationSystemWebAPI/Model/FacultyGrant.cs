using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model
{
    public class FacultyGrant
    {
        public int FacultyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GrantId { get; set; }
        public string GrantTitle { get; set; }
        public string GrantDescription { get; set; }

        
    }
}
