using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentQuest.Models;
using RentQuest.Data;
using Microsoft.EntityFrameworkCore;
using RentQuest.Utility;
using X.PagedList.Mvc.Core;
using X.PagedList;
//using getuserdetails.model;
using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace RentQuest.Controllers
{
    [Area("Owner")]
    public class OwnerController : Controller
    {
        //private readonly UserManager<IdentityUser> userManager;

        private ApplicationDbContext _db;

        public OwnerController(ApplicationDbContext db/*, UserManager<IdentityUser> _userManager*/)
        {
            _db = db;
            //userManager = _userManager;
        }

        public IActionResult Index()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            //ViewBag.userid = userManager.GetUserId(HttpContext.User);
            return View();
        }

        public IActionResult Listing(int? page, decimal? lowamount, decimal? highamount, string PropName, string Loc, string PropType, int? lowbed, int? lowbath, decimal? sizemin, decimal? sizemax)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            var circulation = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount) && (c.Name.Equals(PropName, StringComparison.OrdinalIgnoreCase)) && (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase)) && (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.num_bed >= lowbed) && (c.num_bath >= lowbath) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax)).ToList().ToPagedList(page ?? 1, 6);
            //var circulation2 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Name.Equals(PropName, StringComparison.OrdinalIgnoreCase))).ToList().ToPagedList(page ?? 1, 6);
            if (lowamount == null && highamount == null && PropName == null && Loc == null && PropType == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                circulation = _db.Circulations.Include(c => c.CircTypes).ToList().ToPagedList(page ?? 1, 6);
            }
            else if (PropName != null && lowamount == null && highamount == null && Loc == null && PropType == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation2 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Name.Equals(PropName, StringComparison.OrdinalIgnoreCase))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation2);
            }
            else if (lowamount != null && highamount != null && PropName == null && Loc == null && PropType == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation3 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation3);
            }

            else if (Loc != null && lowamount == null && highamount == null && PropName == null && PropType == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation4 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation4);
            }
            else if (PropType != null && lowamount == null && highamount == null && PropName == null && Loc == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation5 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation5);
            }
            else if (lowbed != null && lowamount == null && highamount == null && PropName == null && Loc == null && PropType == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation6 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.num_bed >= lowbed)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation6);
            }
            else if (lowbath != null && lowamount == null && highamount == null && PropName == null && Loc == null && PropType == null && lowbed == null && sizemin == null && sizemax == null)
            {
                var circulation7 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.num_bath >= lowbath)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation7);
            }
            else if (sizemin != null && sizemax != null && lowamount == null && highamount == null && PropName == null && Loc == null && PropType == null && lowbed == null && lowbath == null)
            {
                var circulation8 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation8);
            }
            else if (Loc != null && PropType != null && lowamount == null && highamount == null && PropName == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation9 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation9);
            }
            else if (lowamount != null && highamount != null && Loc != null && PropName == null && PropType == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation10 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation10);
            }
            else if (lowamount != null && highamount != null && Loc != null && PropType != null && PropName == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation11 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation11);
            }
            else if (Loc != null && PropType != null && sizemin != null && sizemax != null && lowamount == null && highamount == null && PropName == null && lowbed == null && lowbath == null)
            {
                var circulation12 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation12);
            }
            else if (Loc != null && sizemin != null && sizemax != null && lowamount == null && highamount == null && PropName == null && PropType == null && lowbed == null && lowbath == null)
            {
                var circulation13 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation13);
            }
            else if (Loc != null && lowbed != null && lowamount == null && highamount == null && PropName == null && PropType == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation14 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase)) && (c.num_bed >= lowbed)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation14);
            }
            else if (Loc != null && lowbath != null && lowamount == null && highamount == null && PropName == null && PropType == null && lowbed == null && sizemin == null && sizemax == null)
            {
                var circulation15 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase)) && (c.num_bath >= lowbath)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation15);
            }
            else if (lowamount != null && highamount != null && PropType != null && PropName == null && Loc == null && lowbed == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation16 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation16);
            }
            else if (PropType != null && sizemin != null && sizemax != null && lowamount == null && highamount == null && PropName == null && Loc == null && lowbed == null && lowbath == null)
            {
                var circulation17 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation17);
            }
            else if (PropType != null && lowbed != null && lowamount == null && highamount == null && PropName == null && Loc == null && lowbath == null && sizemin == null && sizemax == null)
            {
                var circulation18 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.num_bed >= lowbed)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation18);
            }
            else if (PropType != null && lowbath != null && lowamount == null && highamount == null && PropName == null && Loc == null && lowbed == null && sizemin == null && sizemax == null)
            {
                var circulation19 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.num_bath >= lowbath)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation19);
            }

            else if (Loc != null && lowbath != null && lowbed != null && lowamount == null && highamount == null && PropName == null && PropType == null && sizemin == null && sizemax == null)
            {
                var circulation20 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase)) && (c.num_bath >= lowbath) && (c.num_bed >= lowbed)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation20);
            }

            else if (PropType != null && lowbed != null && lowbath != null && lowamount == null && highamount == null && PropName == null && Loc == null && sizemin == null && sizemax == null)
            {
                var circulation21 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.num_bed >= lowbed) && (c.num_bath >= lowbath)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation21);
            }

            else if (PropType != null && Loc != null && lowbed != null && lowbath != null && lowamount == null && highamount == null && PropName == null && Loc == null && sizemin == null && sizemax == null)
            {
                var circulation22 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase)) && (c.num_bed >= lowbed) && (c.num_bath >= lowbath)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation22);
            }

            else if (Loc != null && PropType != null && sizemin != null && sizemax != null && lowamount != null && highamount != null && PropName == null && lowbed == null && lowbath == null)
            {
                var circulation23 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation23);
            }

            else if (Loc != null && PropType == null && sizemin != null && sizemax != null && lowamount != null && highamount != null && PropName == null && lowbed == null && lowbath == null)
            {
                var circulation24 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.Location.Equals(Loc, StringComparison.OrdinalIgnoreCase) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount))).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation24);
            }

            else if (PropType != null && Loc == null && sizemin != null && sizemax != null && lowamount != null && highamount != null && PropName == null && lowbed == null && lowbath == null)
            {
                var circulation25 = _db.Circulations.Include(c => c.CircTypes).Where(c => (c.CircTypes.CircType.Equals(PropType, StringComparison.OrdinalIgnoreCase)) && (c.SizeSQFT >= sizemin && c.SizeSQFT <= sizemax) && (c.Monthly_Rent >= lowamount && c.Monthly_Rent <= highamount)).ToList().ToPagedList(page ?? 1, 6);
                return View(circulation25);
            }

            return View(circulation);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Detail(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (id == null)
            {
                return NotFound();
            }
            var circulation = _db.Circulations.Include(c => c.CircTypes).FirstOrDefault(c => c.Id == id);
            if (circulation == null)
            {
                return NotFound();
            }
            return View(circulation);
        }

        [HttpPost]
        [ActionName("Detail")]
        public ActionResult CircDetail(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            List<Circulations> circulations = new List<Circulations>();
            if (id == null)
            {
                return NotFound();
            }
            var circulation = _db.Circulations.Include(c => c.CircTypes).FirstOrDefault(c => c.Id == id);
            if (circulation == null)
            {
                return NotFound();
            }

            circulations = HttpContext.Session.Get<List<Circulations>>("circulations");
            if (circulations==null)
            {
                circulations = new List<Circulations>();
            }
            circulations.Add(circulation);
            HttpContext.Session.Set("circulations", circulations);
            return View(circulation);
        }

        [ActionName("Remove")]
        public ActionResult RemoveFromWL(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            List<Circulations> circulations = HttpContext.Session.Get<List<Circulations>>("circulations");
            if (circulations != null)
            {
                var circulation = circulations.FirstOrDefault(c => c.Id == id);

                if (circulation != null)
                {
                    circulations.Remove(circulation);
                    HttpContext.Session.Set("circulations", circulations);
                }
            }
            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public ActionResult Remove(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            List<Circulations> circulations = HttpContext.Session.Get<List<Circulations>>("circulations");
            if(circulations!=null)
            {
                var circulation = circulations.FirstOrDefault(c=>c.Id==id);

                if(circulation!=null)
                {
                    circulations.Remove(circulation);
                    HttpContext.Session.Set("circulations", circulations);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult WL()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            List<Circulations> circulations = HttpContext.Session.Get<List<Circulations>>("circulations");
            if (circulations==null)
            {
                circulations = new List<Circulations>();
            }
            return View(circulations);
        }


        public ActionResult ReceivedReq()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            List<TenantClass> ten = _db.Tenants.ToList();
            List<Circulations> cir = _db.Circulations.ToList();
            List<OwnerClass> own = _db.Owners.ToList();
            List<VisitRequest> vis = _db.VisitRequests.ToList();
            List<ReqDetails> rd = _db.ReqDetails.ToList();

            var newjoin = from t1 in ten
                          join v1 in vis on t1.TEmail equals v1.Email /*into table1*/
                          //from w1 in table1.DefaultIfEmpty()
                          join r1 in rd on v1.Id equals r1.ReqId /*into table2*/
                          //from c1 in table2.DefaultIfEmpty()
                          join c1 in cir on r1.C_Id equals c1.Id
                          join o1 in own on c1.HEmail equals o1.HEmail
                          where o1.HEmail == HttpContext.Session.GetString("ow_email")
                          select new OwnerJoinClass { TDetails = t1, CDetails = c1, OwDetails = o1, ReqDetails = r1, VDetails = v1 };

            return View(newjoin);
        }


        public ActionResult OwCirc(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (id == null)
            {
                return NotFound();
            }

            List<Circulations> cir = _db.Circulations.ToList();
            List<OwnerClass> own = _db.Owners.ToList();


            var oc = from c1 in cir
                     join o1 in own on c1.HEmail equals o1.HEmail
                     where c1.Id == id
                     select new OwCircClass { CDetails = c1, OwDetails = o1 };

            return View(oc);
        }


    }
}
