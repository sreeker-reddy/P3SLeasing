using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentQuest.Data;
using RentQuest.Models;
using RentQuest.Utility;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;

namespace RentQuest.Areas.Tenant.Controllers
{
    [Area("Tenant")]
    public class VisitRequestController : Controller
    {

        private readonly IConfiguration configuration;
        IHostingEnvironment env;
        private ApplicationDbContext _db;

        public VisitRequestController(IConfiguration config, IHostingEnvironment _env, ApplicationDbContext db)
        {
            this.configuration = config;
            this.env = _env;
            _db = db;
        }


        //private ApplicationDbContext _db;

        //public VisitRequestController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}
        public IActionResult Index()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("email");
            return View();
        }

        public IActionResult SendReq()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("email");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> SendReq(VisitRequest avisit)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("email");
            //string mainconn = configuration.GetConnectionString("DefaultConnection");
            //SqlConnection sqlConn = new SqlConnection(mainconn);

            //string sqlquery = "insert into [dbo].[VisitRequests] (TenID,Name,PhoneNo,Email,ReqNo,ReqDate) select TID,TName,TPhone,TEmail,'" + GetReqNo() + "','" + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "' from [dbo].[Tenants] where Tenants.TEmail= '" + HttpContext.Session.GetString("email") + "'";
            //SqlCommand sqlComm = new SqlCommand(sqlquery, sqlConn);
            //sqlConn.Open();


            List<Circulations> circulations = HttpContext.Session.Get<List<Circulations>>("circulations");
            if(circulations!=null)
            {
                foreach (var circ in circulations)
                {
                    ReqDetails reqDetails = new ReqDetails();
                    reqDetails.C_Id = circ.Id;
                    avisit.ReqDetails.Add(reqDetails);
                }
            }

            //TenantClass ten = new TenantClass();
            //if (ten.TEmail== HttpContext.Session.GetString("email")) {
            //    avisit.Name = ten.TName;
                avisit.Email = HttpContext.Session.GetString("email");
            //    avisit.TenID = ten.TID;
                avisit.ReqNo = GetReqNo();
            //    avisit.PhoneNo = ten.TPhone;
                avisit.ReqDate = DateTime.Now;
            //}



            //avisit.ReqNo = GetReqNo();
            _db.VisitRequests.Add(avisit);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("circulations", new List<Circulations>());

            //sqlComm.ExecuteNonQuery();
            //sqlComm.Connection.Close();

            ViewData["Vis"] = "Request Sent";

            return View();
        }

        public string GetReqNo()
        {
            int rowCount = _db.VisitRequests.ToList().Count()+1;
            return rowCount.ToString("000");
        }
    }
}