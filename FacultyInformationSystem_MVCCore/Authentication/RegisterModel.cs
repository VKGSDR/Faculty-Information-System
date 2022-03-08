using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacultyInformationSystem_MVCCore.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-z0-9\-]+\.)+))([a-z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid E-Mail Address ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}
