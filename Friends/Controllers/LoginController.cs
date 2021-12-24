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
    public class LoginController : Controller
    {
        private IFriends IFriendsfact;
        public LoginController(IFriends _friends)
        {
            IFriendsfact = _friends;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = IFriendsfact.CheckLoginDetails(login);
                if (result == null)
                {
                    ViewBag.Message = "Mobile No. or Password is incorrect !!";
                    return View();
                }
                HttpContext.Session.SetString("UserMasterId", Convert.ToString(result.UserMasterID));
            }

            return RedirectToAction("DisplayFriends", "DisplayFriends");
        }
    }
}
