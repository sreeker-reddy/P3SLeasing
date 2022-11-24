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
    [Area("Tenant")]
    public class TLoginController : Controller
    {

        //private readonly UserManager<IdentityUser> userManager;


        private readonly IConfiguration configuration;
        public TLoginController(IConfiguration config/*, UserManager<IdentityUser> _userManager*/)
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
        public IActionResult Index(LoginClass lc)
        {
            const string SessionName = "email";

            string mainconn = configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConn = new SqlConnection(mainconn);
            string sqlquery = "select TEmail,TPwd from [dbo].[Tenants] where TEmail=@TEmail and TPwd=@TPwd";
            sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand(sqlquery, sqlConn);
            sqlComm.Parameters.AddWithValue("@TEmail", lc.Email);
            sqlComm.Parameters.AddWithValue("@TPwd", lc.Password);
            SqlDataReader sdr = sqlComm.ExecuteReader();
            if (sdr.Read())
            {
                HttpContext.Session.SetString(SessionName, lc.Email.ToString());
                //TempData["message"] = SessionName;
                //return RedirectToAction("welcome");
                return RedirectToAction("Index", "Home", new { area = "Tenant" });
            }
            else
            {
                ViewData["Message"] = "Incorrect Details, Try Again";
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