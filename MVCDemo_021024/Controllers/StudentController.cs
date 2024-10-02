using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo_021024.Controllers
{
    public class StudentController : Controller
    {
        //get
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userid1,string password1)
        {
            return View();
        }
        // GET: Student
        public ActionResult Index()
        {
            return View("Index",111);
        }
    }
}