using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItalianResturant.Models;
namespace ItalianResturant.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult AdminEnter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminPass(Validate valid) {



            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader sqldr;

            sqlcon.ConnectionString = "Data Source=DESKTOP-HKD1BEO\\SQLEXPRESS;Initial Catalog=ItalianResturant;Integrated Security=True";
            sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select * from Admin where UserName='" + valid.Name + "' and UserPassword='" +valid.Password + "'";

            sqldr = sqlcmd.ExecuteReader();

            if (sqldr.Read())
            {
                sqlcon.Close();
                return View("AdminPanel");
            }
            else
            {
                sqlcon.Close();
                return View("Wrong");
            }



        }
    }
}