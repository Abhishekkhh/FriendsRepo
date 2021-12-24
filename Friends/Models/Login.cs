using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Mobile No. cannot be blank"), MinLength(10,ErrorMessage ="Mobile No. cannot be less than 10 digits"), MaxLength(20)]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Password cannot be blank"), MinLength(8,ErrorMessage ="Password cannot be less than 8 characters"), MaxLength(20)]
        public string Password { get; set; }
        public int UserMasterID { get; set; }
        public string EmailID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
