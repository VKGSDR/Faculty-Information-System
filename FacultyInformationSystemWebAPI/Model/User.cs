using System;
using System.Collections.Generic;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public byte[] UserPassword { get; set; }
    }
}
