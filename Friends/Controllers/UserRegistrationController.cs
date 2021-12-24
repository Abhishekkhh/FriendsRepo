using Dapper;
using Friends.BusinessLogic;
using Friends.Models;
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
    public class UserRegistrationController : Controller
    {
        private IFriends IFriendsfact;
        public UserRegistrationController(IFriends _friends)
        {
            IFriendsfact = _friends;
        }
        [HttpGet]
        public IActionResult UserRegistration()
        {
            User user = new User();
            return View(user);
        }


        [HttpPost]
        public IActionResult UserRegistration(User user)
        {
            if (ModelState.IsValid)
            {
                var result = IFriendsfact.SaveUserDetails(user);
                if (result.ErrorCode)
                {
                    TempData["Message"] = result.Message;
                    return View(user);
                }
            }

            return RedirectToAction("Login", "Login");
        }
    }
}
