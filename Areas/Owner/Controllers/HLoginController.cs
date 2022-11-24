using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RentQuest.Models;
//using Microsoft.AspNetCore.Identity;

namespace RentQuest.Areas.Tenant.Controllers
{
    [Area("Owner")]
    public class HLoginController : Controller
    {

        //private readonly UserManager<IdentityUser> userManager;


        private readonly IConfiguration configuration;
        public HLoginController(IConfiguration config/*, UserManager<IdentityUser> _userManager*/)
        {
            this.configuration = config;
            //userManager = _userManager;
        }

        public IActionResult Index()
        {
            //ViewBag.userid = userManager.GetUserId(HttpContext.User);
            return View();
        }

        [HttpPost]
        public IActionResult Index(OwLogin lc)
        {
            const string SessionName = "ow_email";

            string mainconn = configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConn = new SqlConnection(mainconn);
            string sqlquery = "select HEmail,HPwd from [dbo].[Owners] where HEmail=@HEmail and HPwd=@HPwd";
            sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand(sqlquery, sqlConn);
            sqlComm.Parameters.AddWithValue("@HEmail", lc.H_Email);
            sqlComm.Parameters.AddWithValue("@HPwd", lc.H_Password);
            SqlDataReader sdr = sqlComm.ExecuteReader();
            if (sdr.Read())
            {
                HttpContext.Session.SetString(SessionName, lc.H_Email.ToString());
                //TempData["message"] = SessionName;
                //return RedirectToAction("welcome");
                return RedirectToAction("Index", "Owner", new { area = "Owner" });
            }
            else
            {
                ViewData["WMessage"] = "Incorrect Details, Try Again";
            }

            sqlConn.Close();
            return View();
        }

        public IActionResult welcome()
        {
            //ViewBag.sessionv = HttpContext.Session.GetString("email");
            return View();
        }
    }
}