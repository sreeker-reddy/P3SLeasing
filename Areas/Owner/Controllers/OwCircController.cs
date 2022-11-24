using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentQuest.Data;
using RentQuest.Models;

namespace RentQuest.Areas.Admin.Controllers
{
    [Area("Owner")]
    public class OwCircController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        public OwCircController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        public IActionResult Index(OwnerClass ow)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            return View(_db.Circulations.Include(c => c.CircTypes).Where(c => c.HEmail == HttpContext.Session.GetString("ow_email")).ToList());
            //.Where(c => c.HEmail == ow.HEmail)
        }

        [HttpPost]
        public IActionResult Index(decimal? lowamount,decimal? highamount)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            var circulation = _db.Circulations.Include(c => c.CircTypes).Where(c =>(c.Monthly_Rent>=lowamount && c.Monthly_Rent <= highamount)&&(c.HEmail == HttpContext.Session.GetString("ow_email"))).ToList();
            if(lowamount==null || highamount==null)
            {
                circulation = _db.Circulations.Include(c => c.CircTypes).Where(c => c.HEmail == HttpContext.Session.GetString("ow_email")).ToList();
            }
            return View(circulation);
        }

        //Get Create Method
        public IActionResult Create()
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            ViewData["CircTypeId"] = new SelectList(_db.CircTypes.ToList(), "Id", "CircType");

            return View();
        }

        //Post Create Method
        [HttpPost]
        public async Task<IActionResult> Create(Circulations circulations, IFormFile image)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (ModelState.IsValid)
            {
                var searchCirc = _db.Circulations.FirstOrDefault(c=>c.Name==circulations.Name);

                if(searchCirc!=null)
                {
                    ViewBag.message = "This circulation already exists";
                    ViewData["CircTypeId"] = new SelectList(_db.CircTypes.ToList(), "Id", "CircType");
                    return View(circulations);
                }

                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    circulations.Image = "Images/" + image.FileName;
                }

                if (image == null)
                {
                    circulations.Image = "Images/No-image-found.jpg";
                }

                if(HttpContext.Session.GetString("ow_email")!=null)
                {
                    circulations.HEmail = HttpContext.Session.GetString("ow_email");
                }

                _db.Circulations.Add(circulations);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circulations);
        }

        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            ViewData["CircTypeId"] = new SelectList(_db.CircTypes.ToList(), "Id", "CircType");
            if (id == null) {
                return NotFound();
            }
            var circulation = _db.Circulations.Include(c => c.CircTypes).FirstOrDefault(c => c.Id == id);
            if (circulation == null)
            {
                return NotFound();
            }
            return View(circulation);
        }

        //Post Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(Circulations circulations, IFormFile image)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    circulations.Image = "Images/" + image.FileName;
                }

                if (image == null)
                {
                    circulations.Image = "Images/No-image-found.jpg";
                }

                if (HttpContext.Session.GetString("ow_email") != null)
                {
                    circulations.HEmail = HttpContext.Session.GetString("ow_email");
                }

                _db.Circulations.Update(circulations);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circulations);
        }

        //GET Details Action Method

        public ActionResult Details(int? id)
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

        public ActionResult Delete(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (id == null)
            {
                return NotFound();
            }
            var circulation = _db.Circulations.Include(c => c.CircTypes).Where(c => c.Id == id).FirstOrDefault();
            if (circulation == null)
            {
                return NotFound();
            }
            return View(circulation);
        }

        [HttpPost]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            ViewBag.sessionv = HttpContext.Session.GetString("ow_email");
            if (id == null)
            {
                return NotFound();
            }
            var circulation = _db.Circulations.FirstOrDefault(c => c.Id == id);
            if (circulation == null)
            {
                return NotFound();
            }
            _db.Circulations.Remove(circulation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}