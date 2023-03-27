using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace ProyectoFinalWeb.Entities
{
    public class TestimoniosEnt
    {
        public long id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string mensaje { get; set; }

        public string imagen_URL { get; set; }
    }
}