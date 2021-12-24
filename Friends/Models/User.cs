using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class User
    {
        public int UserMasterId { get; set; }
        [Required(ErrorMessage = "First name cannot be blank"), MaxLength(50)]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name cannot be blank"), MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailID cannot be blank"), MaxLength(100)]
        [EmailAddress(ErrorMessage="Email Address not in correct format")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Mobile No. cannot be blank"), MinLength(10, ErrorMessage = "Mobile No. cannot be less than 10 digits"), MaxLength(20)]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Password cannot be blank"), MinLength(8, ErrorMessage = "Password cannot be less than 8 characters"), MaxLength(20)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password cannot be blank"), MinLength(8, ErrorMessage = "Confirm Password cannot be less than 8 characters"), MaxLength(20)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }







    }
}
