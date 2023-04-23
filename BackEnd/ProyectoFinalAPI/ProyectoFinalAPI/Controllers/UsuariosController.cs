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
        LogsModel logModel = new LogsModel();

        [HttpPost]
        [AllowAnonymous]
        [Route("api/AdoptarMascota")]
        public int AdoptarMascota(AdoptarEnt entidad)
        {
            return model.AdoptarMascota(entidad);
        }

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
        [HttpPost]
        [AllowAnonymous]

        [Route("api/GenerarContrasenna")]
        public void GenerarContrasenna(UsuariosEnt entidad)
        {
            model.GenerarContrasenna(entidad);
        }

        [HttpPost]
        [Route("api/RecuperarContrasenna")]
        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            logModel.RecuperarContrasenna(entidad);
        }

        [HttpPost]
        [Authorize]
        [Route("api/AgregarTestimonio")]
        public int AgregarTestimonio(TestimoniosEnt entidad)
        {
            return model.AgregarTestimonio(entidad);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/Donar")]
        public int Donar(DonacionesEnt entidad)
        {
            return model.Donar(entidad);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/AgregarVoluntario")]
        public int AgregarVoluntario(VoluntariosEnt entidad)
        {
            return model.AgregarVoluntario(entidad);
        }
    }
}