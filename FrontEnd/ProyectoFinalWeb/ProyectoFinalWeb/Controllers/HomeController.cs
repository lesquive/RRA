using ProyectoFinalWeb.Entities;
using ProyectoFinalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalWeb.Controllers
{
    public class HomeController : Controller
    {
        HomeModel homeModel = new HomeModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult RegistrarUsuario()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return View("Index");
            }
        }

        [HttpPost]
        public ActionResult RegistrarUsuario(UsuariosEnt entidad)
        {
            try
            {
                if (homeModel.RegistrarUsuario(entidad) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mensaje = "No se pudo registrar su cuenta";
                    return View("Index");
                }

            }
            catch (Exception)
            {

                return View("Index");
            }
        }

        [HttpPost]
        public ActionResult BuscarCorreo(string correoValidar)
        {
            return Json(homeModel.BuscarCorreo(correoValidar), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult RecuperarContrasenna()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return View("Index");
            }
        }

        [HttpPost]
        public ActionResult RecuperarContrasenna(UsuariosEnt entidad)
        {
            try
            {
                homeModel.RecuperarContrasenna(entidad);
                return View("index");
            }
            catch (Exception)
            {
                return View("Index");
            }
        }
    }
}