using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProyectoFinalAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AnimalesController : ApiController
    {
        AnimalesModel model = new AnimalesModel();

        //GET Animals Disponibles para Adoptar
        [HttpGet]
        [AllowAnonymous]
        [Route("api/ConsultarAnimalesParaAdopcion")]
        public List<AnimalesEnt> ConsultarAnimalesParaAdopcion()
        {
            return model.ConsultarAnimalesParaAdopcion();
        }

        //GET Testimonios de adopciones 

        [HttpGet]
        [AllowAnonymous]
        [Route("api/ConsultarTestimonios")]
        public List<TestimoniosEnt> ConsultarTestimonios()
        {
            return model.ConsultarTestimonios();
        }
        
        //GET Voluntarios para adopciones
        [HttpGet]
        [AllowAnonymous]
        [Route("api/ConsultarVoluntarios")]
        public List<VoluntariosEnt> ConsultarVoluntarios()
        {
            return model.ConsultarVoluntarios();
        }

    }
}
