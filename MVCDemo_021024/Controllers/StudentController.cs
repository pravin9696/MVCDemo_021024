using MVCDemo_021024.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo_021024.Controllers
{
    public class StudentController : Controller
    {
      
        public ActionResult NewLogin()
        {
           
            return View();

        }
        [HttpPost]
        public ActionResult NewLogin(MyLoginClass obj)
        {

            return View();

        }
        [HttpPost]
        public ActionResult LoginByFormCollection(FormCollection frmc)
        {
            string uid = frmc["userid1"];
            string pass = frmc["password1"];
            return View();
        }
        public ActionResult LoginByRequest()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult LoginByRequest1()
        {
            string userName = Request["userid1"];
            string password = Request["password1"];
            //ADO.net code and  check user id and password
            //1
            SqlConnection con = new SqlConnection("Data Source=Desktop-ABKHEEV;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            
            //2
            SqlDataAdapter adp = new SqlDataAdapter($"select * from tbllogin where userID='{userName}' AND password1='{password}' ", con);
            SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);

            //3
            DataSet ds = new DataSet();


            adp.Fill(ds, "tbllogin");

            if (ds.Tables["tbllogin"].Rows.Count>0)
            {
              
            }
            else
            {

            }

            return View("Login");
        }
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