using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentQuest.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Hosting;

namespace RentQuest.Areas.Tenant.Controllers
{
    [Area("Tenant")]

    public class TRegController : Controller
    {
        private readonly IConfiguration configuration;
        IHostingEnvironment env;

        public TRegController(IConfiguration config, IHostingEnvironment _env)
        {
            this.configuration = config;
            this.env = _env;
        }


        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(TenantClass tc, IFormFile file)
        {
            var webroot = env.WebRootPath;
            string mainconn = configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[Tenants] (TName,TEmail,TPwd,TGender,TDOB,TPhone,TImg) values (@TName,@TEmail,@TPwd,@TGender,@TDOB,@TPhone,@TImg)";
            SqlCommand sqlComm = new SqlCommand(sqlquery, sqlConn);
            sqlConn.Open();
            sqlComm.Parameters.AddWithValue("@TName", tc.TName);
            sqlComm.Parameters.AddWithValue("@TEmail", tc.TEmail);
            //if (tc.TEmail.Length !=0)
            //{
            //    Regex regex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");

            //    if(!regex.IsMatch(tc.TEmail))
            //    {
            //        ModelState.AddModelError("TEmail", "Incorrect Email Format");
            //    }
            //    ViewBag.emailerror = "*";
            //}
            sqlComm.Parameters.AddWithValue("@Tpwd", tc.TPwd);
            sqlComm.Parameters.AddWithValue("@TGender", tc.TGender);
            sqlComm.Parameters.AddWithValue("@TDOB", tc.TDOB);
            sqlComm.Parameters.AddWithValue("@TPhone", tc.TPhone);
            //sqlComm.Parameters.AddWithValue("@TImg", tc.TImg);
            if (file != null && file.Length > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imagepath = Path.Combine(webroot, filename);
                using (var fileStream = new FileStream(imagepath, FileMode.Create))
                {
                    file.CopyToAsync(fileStream);
                }
            }
            sqlComm.Parameters.AddWithValue("@TImg", webroot + file.FileName);
            sqlComm.ExecuteNonQuery();
            sqlComm.Connection.Close();
            ViewData["Message"] = "Tenant Record " + tc.TName + " is saved ";
            return View();
        }
    }
}