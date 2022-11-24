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
    [Area("Owner")]

    public class HRegController : Controller
    {
        private readonly IConfiguration configuration;
        IHostingEnvironment env;

        public HRegController(IConfiguration config, IHostingEnvironment _env)
        {
            this.configuration = config;
            this.env = _env;
        }


        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Index(OwnerClass tc, IFormFile file)
        {
            var webroot = env.WebRootPath;
            string mainconn = configuration.GetConnectionString("DefaultConnection");
            SqlConnection sqlConn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[Owners] (HName,HEmail,HPwd,HGender,HDOB,HPhone,HImg) values (@HName,@HEmail,@HPwd,@HGender,@HDOB,@HPhone,@HImg)";
            SqlCommand sqlComm = new SqlCommand(sqlquery, sqlConn);
            sqlConn.Open();
            sqlComm.Parameters.AddWithValue("@HName", tc.HName);
            sqlComm.Parameters.AddWithValue("@HEmail", tc.HEmail);
            //if (tc.TEmail.Length !=0)
            //{
            //    Regex regex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");

            //    if(!regex.IsMatch(tc.TEmail))
            //    {
            //        ModelState.AddModelError("TEmail", "Incorrect Email Format");
            //    }
            //    ViewBag.emailerror = "*";
            //}
            sqlComm.Parameters.AddWithValue("@HPwd", tc.HPwd);
            sqlComm.Parameters.AddWithValue("@HGender", tc.HGender);
            sqlComm.Parameters.AddWithValue("@HDOB", tc.HDOB);
            sqlComm.Parameters.AddWithValue("@HPhone", tc.HPhone);
          
            //if (file != null && file.Length > 0)
            //{
            //    string filename = Path.GetFileName(file.FileName);
            //    string imagepath = Path.Combine(webroot, filename);
            //    using (var fileStream = new FileStream(imagepath, FileMode.Create))
            //    {
            //        file.CopyToAsync(fileStream);
            //    }
            //}
            //sqlComm.Parameters.AddWithValue("@HImg", webroot + "/Images"+ file.FileName);


            if (file != null)
            {
                var name = Path.Combine(env.WebRootPath + "/Images", Path.GetFileName(file.FileName));
                await file.CopyToAsync(new FileStream(name, FileMode.Create));
                sqlComm.Parameters.AddWithValue("@HImg", "Images/" + file.FileName);
                
            }

            if (file == null)
            {
                sqlComm.Parameters.AddWithValue("@HImg", "Images/No-image-found.jpg");
            }


            sqlComm.ExecuteNonQuery();
            sqlComm.Connection.Close();
            ViewData["HMessage"] = "Owner Record " + tc.HName + " is saved ";
            return View();
        }
    }
}