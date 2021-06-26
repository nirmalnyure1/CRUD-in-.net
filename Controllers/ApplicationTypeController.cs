using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ApplicationTypeController : Controller

    {


        private readonly ApplicationDbcontext _db;
        public ApplicationTypeController (ApplicationDbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()

        {

            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View(objList);
            //return View();
        }

        //Get Create
        public IActionResult Create()
        {

            return View();
        }

        //Post create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        //Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.ApplicationType.Find(id);
            if (obj == null)
            {
               return  NotFound();
            }

            return View(obj);
        }

        //Post create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationType obj)
        {
            if (ModelState.IsValid)
            {
                _db.ApplicationType.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
           
        }

        public IActionResult Delete(int? id)
        {
            if(id==null|| id == 0)
            {
                return NotFound();
            }
            var obj = _db.ApplicationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult DeletePost(int? id)
        {

            if(id==null || id == 0)
            {
                return NotFound();

            }
            var obj = _db.ApplicationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.ApplicationType.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
