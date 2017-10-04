using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeliveryOnline.Models;

namespace DeliveryOnline.Controllers
{
    public class TiposMenusController : Controller
    {
        private DeliveryOnLineContext db = new DeliveryOnLineContext();

        // GET: TiposMenus
        public ActionResult Index()
        {
            return View(db.TipoMenus.ToList());
        }

        // GET: TiposMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposMenu tiposMenu = db.TipoMenus.Find(id);
            if (tiposMenu == null)
            {
                return HttpNotFound();
            }
            return View(tiposMenu);
        }

        // GET: TiposMenus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposMenus/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodigoId,Descripcion")] TiposMenu tiposMenu)
        {
            if (ModelState.IsValid)
            {
                db.TipoMenus.Add(tiposMenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tiposMenu);
        }

        // GET: TiposMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposMenu tiposMenu = db.TipoMenus.Find(id);
            if (tiposMenu == null)
            {
                return HttpNotFound();
            }
            return View(tiposMenu);
        }

        // POST: TiposMenus/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,Descripcion")] TiposMenu tiposMenu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tiposMenu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tiposMenu);
        }

        // GET: TiposMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiposMenu tiposMenu = db.TipoMenus.Find(id);
            if (tiposMenu == null)
            {
                return HttpNotFound();
            }
            return View(tiposMenu);
        }

        // POST: TiposMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TiposMenu tiposMenu = db.TipoMenus.Find(id);
            db.TipoMenus.Remove(tiposMenu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
