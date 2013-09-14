using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nyumbaleo.Models;

namespace nyumbaleo.Controllers
{
    public class PropertyController : Controller
    {
        private PropertyContext db = new PropertyContext();

        //
        // GET: /Property/

        public ActionResult Index()
        {
            return View(db.properties.ToList());
        }

        //
        // GET: /Property/Details/5

        public ActionResult Details(int id = 0)
        {
            property property = db.properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        //
        // GET: /Property/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Property/Create

        [HttpPost]
        public ActionResult Create(property property)
        {
            if (ModelState.IsValid)
            {
                db.properties.Add(property);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(property);
        }

        //
        // GET: /Property/Edit/5

        public ActionResult Edit(int id = 0)
        {
            property property = db.properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        //
        // POST: /Property/Edit/5

        [HttpPost]
        public ActionResult Edit(property property)
        {
            if (ModelState.IsValid)
            {
                db.Entry(property).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(property);
        }

        //
        // GET: /Property/Delete/5

        public ActionResult Delete(int id = 0)
        {
            property property = db.properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        //
        // POST: /Property/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            property property = db.properties.Find(id);
            db.properties.Remove(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}