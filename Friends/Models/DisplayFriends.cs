using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Models
{
    public class DisplayFriends
    {
        public bool isChecked { get; set; }
        public int FriendId { get; set; }
        [Required(ErrorMessage = "First name cannot be blank"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name cannot be blank"), MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailID cannot be blank"), MaxLength(100)]
        [EmailAddress(ErrorMessage = "Email Address not in correct format")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Mobile No. cannot be blank"), MinLength(10, ErrorMessage = "Mobile No. cannot be less than 10 digits"), MaxLength(20)]
        public string MobileNo { get; set; }
    }

    public class DisplayFriendsList
    {
        public List<DisplayFriends> friendlist { get; set; }
    }

}
