using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMvcStore.Models;

namespace OnlineMvcStore.Controllers
{
    public class ManufacturerController : Controller
    {
        private OnlineMvcStoreDb db = new OnlineMvcStoreDb();

        //
        // GET: /Manfufacturer/

        public ActionResult Index()
        {
            return View(db.Manufacturers.ToList());
        }

        //
        // GET: /Manfufacturer/Details/5

        public ActionResult Details(long id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // GET: /Manfufacturer/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Manfufacturer/Create

        [HttpPost]
        [Authorize]
        public ActionResult Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Manufacturers.Add(manufacturer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturer);
        }

        //
        // GET: /Manfufacturer/Edit/5
        [Authorize]
        public ActionResult Edit(long id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // POST: /Manfufacturer/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturer);
        }

        //
        // GET: /Manfufacturer/Delete/5
        [Authorize]
        public ActionResult Delete(long id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // POST: /Manfufacturer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            db.Manufacturers.Remove(manufacturer);
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