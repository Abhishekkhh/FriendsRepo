using Dapper;
using Friends.BusinessLogic;
using Friends.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.Controllers
{
    public class DisplayFriendsController : Controller
    {
        private IFriends IFriendsfact;
        public DisplayFriendsController(IFriends _friends)
        {
            IFriendsfact = _friends;
        }
        public IActionResult DisplayFriends()
        {
            List<DisplayFriends> returnlst = new List<DisplayFriends>();
            returnlst = IFriendsfact.GetDisplayFriends();

            return View(returnlst);
        }

        [HttpPost]
        public IActionResult DisplayFriends(List<DisplayFriends> df)
        {
            string deletefrnds = String.Join(",", df.Where(m => m.isChecked == true).Select(m => m.FriendId).ToList());
            if (string.IsNullOrEmpty(deletefrnds))
            {
                TempData["Message"] = "Please select atleast one Friend to delete !! ";
            }
            else
            {
                var result = IFriendsfact.SaveFriend(HttpContext.Session.GetString("UserMasterId"), deletefrnds);
                TempData["Message"] = result.Message;
            }

            return RedirectToAction("DisplayFriends", "DisplayFriends");
        }
    }
}
