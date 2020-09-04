using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiSitioWeb.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Models.Contacto contacto)
        {
            var db = new Models.ContactoContext();
            db.Contactos.Add(contacto);
            try
            {
                db.SaveChanges();
                ViewBag.Message = "Tu mensaje se ha guardado";
            }
            catch (Exception)
            {

                ViewBag.Message = "Error al guardar";
            }
            //ViewBag.Message = "Si requieres servicios de desarrollo de software o tienes preguntas , contactame";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Si requieres servicios de desarrollo de software o tienes preguntas , contactame";

            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
    }
}