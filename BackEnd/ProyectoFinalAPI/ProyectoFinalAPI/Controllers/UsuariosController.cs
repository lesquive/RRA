using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinalAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        HomeModel model = new HomeModel();

        [HttpPost]
        [Route("api/AdoptarMascota")]
        public int AdoptarMascota(AdoptarEnt entidad)
        {
            return model.AdoptarMascota(entidad);
        }

        [HttpPost]
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
        [HttpPost]
        [Route("api/RecuperarContrasenna")]
        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            model.RecuperarContrasenna(entidad);
        }

    }
}