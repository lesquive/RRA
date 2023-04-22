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

        [HttpPost]
        public ActionResult Panel(UsuariosEnt entidad)
        {
            try
            {
                var resultado = homeModel.ValidarUsuario(entidad);

                if (resultado != null)
                {
                    Session["email"] = resultado.email;
                    Session["id"] = resultado.id;
                    Session["nombre"] = resultado.nombre;
                    Session["apellido"] = resultado.apellido;
                    return View();
                }
                else
                {
                    ViewBag.mensaje = "Sus credenciales no fueron validados";
                    return View("Index");
                }
            }
            catch (Exception)
            {
                return View("Index");
            }
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

        [HttpGet]
        public ActionResult IniciarSesion()
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
        public ActionResult IniciarSesion(UsuariosEnt entidad)
        {
            try
            {
                var resultado = homeModel.ValidarUsuario(entidad);

                if (resultado != null)
                {
                    Session["Email"] = resultado.email;
                    Session["Id"] = resultado.id;
                    return View();
                }
                else
                {
                    ViewBag.mensaje = "Sus credenciales no fueron validados";
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

        [HttpGet]
        public ActionResult AgregarTestimonio()
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
        public ActionResult AgregarTestimonio(TestimoniosEnt entidad)
        {
            try
            {
                if (homeModel.AgregarTestimonio(entidad) > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mensaje = "No se pudo agregar su testimonio";
                    return View("Index");
                }

            }
            catch (Exception)
            {

                return View("Index");
            }
        }

    }
}