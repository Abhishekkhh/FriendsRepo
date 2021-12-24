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
    public class FriendsDetailsController : Controller
    {
        private IFriends IFriendsfact;
        public FriendsDetailsController(IFriends _friends)
        {
            IFriendsfact = _friends;
        }
        public IActionResult FriendsDetails(int FriendId)
        {
            DisplayFriends df = new DisplayFriends();
            if (FriendId != 0)
            {
                df = IFriendsfact.GetFriendDetails(FriendId);
            }

            return View(df);
        }

        [HttpPost]
        public IActionResult FriendsDetails(DisplayFriends df)
        {
            if (ModelState.IsValid)
            {
                var result = IFriendsfact.SaveFriendDetails(df, HttpContext.Session.GetString("UserMasterId"));

                TempData["Message"] = result.Message;
                if (result.ErrorCode)
                {
                    return View(df);
                }
            }

            return RedirectToAction("FriendsDetails");
        }

    }
}
