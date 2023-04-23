using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class DonacionesEnt
    {
        public int id { get; set; }

        public int refugio_ID { get; set; }

        public int donante_ID { get; set; }

        public DateTime fecha { get; set; }

        public int cantidad { get; set; }
    }
}