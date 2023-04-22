using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class TestimoniosEnt
    {
        public long id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string mensaje { get; set; }

        public int usuario_id { get; set; }

        public string imagen_URL { get; set; }
    }
}