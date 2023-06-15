using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id, string nombre)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario) {
            string nombre, apellido;

            nombre = formulario["nombre"].ToString();
            apellido = formulario["apellido"].ToString();

            return Content("Llegaron los datos, nombre " + nombre + " apellido " 
                + apellido);

        }
    }
}