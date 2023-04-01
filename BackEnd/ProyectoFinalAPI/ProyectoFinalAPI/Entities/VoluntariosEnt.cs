using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class VoluntariosEnt
    {
        public long id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string disponibilidad { get; set; }

        public string imagen_URL { get; set; }
    }
}