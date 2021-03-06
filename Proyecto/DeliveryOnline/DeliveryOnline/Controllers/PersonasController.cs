﻿using System;
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
    public class PersonasController : Controller
    {
        private DeliveryOnLineContext db = new DeliveryOnLineContext();

        // GET: Personas
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Usuarios.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            PopulateTioClienteDropDownList();
            return View();
        }

        // POST: Personas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteId,Nombre,Apellidos,Direccion,Email,FonoCelular,Usuario,Password")] Persona persona)
        {
            //Add try: Eincio
            try
            {
                if (ModelState.IsValid)
                {
                    db.Usuarios.Add(persona);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                //throw;
                ModelState.AddModelError("", "No se pueden guardar los cambios. Inténtalo de nuevo, y si el problema persiste, consulte al administrador del sistema.");
            }

            PopulateTioClienteDropDownList(persona.ClienteId);
            //linea se mantiene
            return View(persona);
        }

        //Add: EIncio
        private void PopulateTioClienteDropDownList(object selectTipoCliente = null)
        {
            var tipoClienteQuery = from tc in db.TipoClientes
                                   orderby tc.Descripcion
                                   select tc;

            ViewBag.ClienteId = new SelectList(tipoClienteQuery, "ClienteId", "Descripcion", selectTipoCliente);

        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Usuarios.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodigoId,Nombre,Apellidos,Direccion,Email,FonoCelular,Usuario,Password")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Usuarios.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Usuarios.Find(id);
            db.Usuarios.Remove(persona);
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
