using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryOnline.Controllers
{
    public class TiendaController : Controller
    {
        /// <summary>
        /// Registra una nueva tienda en el sistema
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        /// <summary>
        /// Guarda el nuevo registro de tienda en persistencia
        /// </summary>
        /// <param name="tienda"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Registrar(Models.Tienda tienda)
        {
            if (ModelState.IsValid)
            {
                tienda.FechaRegsitro = DateTime.Now;
                // guardarDb(tienda);
                return RedirectToAction("BuscarTienda", new { id = tienda.CodigoId });
            }
            else
            {
                return View(tienda);
            }
        }

        /// <summary>
        /// Recupera una tienda
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult BuscarTienda(int id)
        {
            return View();
        }

        /// <summary>
        /// Actualiza los datos de una tienda
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ActualizarTienda()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActualizarTienda(Models.Tienda tienda)
        {
            return View();
        }

        /// <summary>
        /// Borra logicamente la tienda del sistema
        /// </summary>
        /// <returns></returns>
        public ActionResult InactivarTienda(int id)
        {
            return View();
        }

        [ActionName("InactivarTienda")]
        public ActionResult InactivarTiendaConfirmed(int id)
        {
            return View();
        }

        /// <summary>
        /// Retorna toda la lista de tiendas.
        /// </summary>
        /// <returns></returns>
        public ActionResult ListarTiendas()
        {
            return View();
        }

        public ActionResult ListarTiendasYProductos()
        {
            return View();
        }
    }
}