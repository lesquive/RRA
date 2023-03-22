using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class AnimalesEnt
    {
        public long id { get; set; }

        public string nombre { get; set; }

        public string especie { get; set; }

        public string raza { get; set; }

        public int edad { get; set; }

        public string estado_salud { get; set; }

        public int refugio_ID { get; set; }

        public string imagen_URL { get; set; }
    }
}