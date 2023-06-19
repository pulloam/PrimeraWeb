using PrimeraWeb.Models;
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
            string nombre, clave;

            nombre = formulario["nombre"].ToString();
            clave = formulario["clave"].ToString();

            if(clave == "123456") {
                Usuario usuario = new Usuario();
                usuario.Nombre = nombre;
                usuario.Clave = clave;

                TempData["usuario"] = usuario;

                return RedirectToAction("HomeUsuario");
            } else {
                if(clave == "") { 
                    ViewBag.Error = "Debe ingresar clave";
                } else {
                    ViewBag.Error = "Credenciales erroneas";
                }

                return View();
            }

        }

        public ActionResult HomeUsuario() {
            ViewBag.Usuario = ((Usuario) TempData["usuario"]);
            return View();
        }
    }
}