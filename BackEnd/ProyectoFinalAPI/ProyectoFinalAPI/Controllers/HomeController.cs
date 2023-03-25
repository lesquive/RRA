using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        HomeModel model = new HomeModel();

        [HttpPost]
        [AllowAnonymous]
        [Route("api/ValidarUsuario")]
        public UsuariosEnt ValidarUsuario(UsuariosEnt entidad)
        {
            return model.ValidarUsuario(entidad);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/RegistrarUsuario")]
        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            return model.RegistrarUsuario(entidad);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("api/BuscarCorreo")]
        public string BuscarCorreo(string correoValidar)
        {
            return model.BuscarCorreo(correoValidar);
        }


    }

}
