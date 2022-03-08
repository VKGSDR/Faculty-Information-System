using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacultyInformationSystemWebAPI.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="User Name is Required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }
    }
}
