using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentQuest.Data;
using RentQuest.Models;

namespace RentQuest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CircTypesController : Controller
    {
        private ApplicationDbContext _db;

        public CircTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.CircTypes.ToList());
        }

        //create get action method
        public ActionResult Create()
        {
            return View();
        }

        //create post action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CircTypes circTypes)
        {
            if (ModelState.IsValid)
            {
                _db.CircTypes.Add(circTypes);
                await _db.SaveChangesAsync();
                TempData["save"] = "Circulation Type has been saved";
                return RedirectToAction(nameof(Index));
            }

            return View(circTypes);
        }

        //edit get action method
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var circType = _db.CircTypes.Find(id);
            if(circType==null)
            {
                return NotFound();
            }
            return View(circType);
        }

        //edit post action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CircTypes circTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(circTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(circTypes);
        }

        //details get action method
        public ActionResult Dettails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var circType = _db.CircTypes.Find(id);
            if (circType == null)
            {
                return NotFound();
            }
            return View(circType);
        }

        //details post action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Dettails(CircTypes circTypes)
        {
            return RedirectToAction(nameof(Index));
        }

        //delete get action method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var circType = _db.CircTypes.Find(id);
            if (circType == null)
            {
                return NotFound();
            }
            return View(circType);
        }

        //delete post action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, CircTypes circTypes)
        {
            if (id == null)
            {
                return NotFound();
            }
            if(id != circTypes.Id)
            {
                return NotFound();
            }

            var circType = _db.CircTypes.Find(id);
            if (circType == null)
            {
                return NotFound(); 
            }
            if (ModelState.IsValid)
            {
                _db.Remove(circType);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(circTypes);
        }
    }
}