﻿using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinalAPI.Controllers
{
    public class AnimalesController : ApiController
    {
        AnimalesModel model = new AnimalesModel();

        //GET Animals Disponibles para Adoptar
        [HttpGet]
        [Route("api/ConsultarAnimalesParaAdopcion")]
        public List<AnimalesEnt> ConsultarAnimalesParaAdopcion()
        {
            return model.ConsultarAnimalesParaAdopcion();
        }
    }
}