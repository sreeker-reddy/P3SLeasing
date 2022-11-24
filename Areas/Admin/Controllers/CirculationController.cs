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
    [Area("Admin")]
    public class CirculationController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        public CirculationController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_db.Circulations.Include(c => c.CircTypes).ToList());
        }

        [HttpPost]
        public IActionResult Index(decimal? lowamount,decimal? highamount)
        {
            var circulation = _db.Circulations.Include(c => c.CircTypes).Where(c =>c.Monthly_Rent>=lowamount && c.Monthly_Rent <= highamount).ToList();
            if(lowamount==null || highamount==null)
            {
                circulation = _db.Circulations.Include(c => c.CircTypes).ToList();
            }
            return View(circulation);
        }

        //Get Create Method
        public IActionResult Create()
        {
            ViewData["CircTypeId"] = new SelectList(_db.CircTypes.ToList(), "Id", "CircType");

            return View();
        }

        //Post Create Method
        [HttpPost]
        public async Task<IActionResult> Create(Circulations circulations, IFormFile image)
        {
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
                _db.Circulations.Add(circulations);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circulations);
        }

        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
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
                _db.Circulations.Update(circulations);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(circulations);
        }

        //GET Details Action Method

        public ActionResult Details(int? id)
        {
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