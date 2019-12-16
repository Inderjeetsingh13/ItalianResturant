using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItalianResturant.Models;

namespace ItalianResturant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Gallery()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        [HttpPost]
        public ActionResult MailPass(Query query) {


            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcon.ConnectionString = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=ItalianResturant;Integrated Security=True";




            sqlcon.Open();
            sqlcmd.Connection = sqlcon;

            sqlcmd.CommandText = "insert into Mail(Name,Email,Phone,Subject,Message) values('" + query.Name + "','" + query.Email + "','"+query.Phone+"','" + query.Subject + "','" + query.Message + "')";
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();


            return View("ReturnMessage");
        }

    }
}   