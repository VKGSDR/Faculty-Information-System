using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystem_MVCCore.Authentication
{
    public class LoginGet
    {
        public DateTime ValidUpTo { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }

        public int Id { get; set; }
    }
}

