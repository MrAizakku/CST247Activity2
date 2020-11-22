using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var users = getUserList();
            return View("Test", users);
        }

        public List<UserModel> getUserList()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Jon Abbot", "Vampire@hotmail.com", "555-444-3333"));
            users.Add(new UserModel("Trevenor Belmont", "VampireKiller@hotmail.com", "555-443-3333"));
            users.Add(new UserModel("ALucard Teppes", "Vampir3@hotmail.com", "555-434-3343"));
            return users;
        }
    }
}