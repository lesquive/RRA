using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class AdoptarEnt
    {
        public long id { get; set; }

        public int animal_ID { get; set; }

        public int refugio_ID { get; set; }

        public int adoptante_ID { get; set; }

        public DateTime fecha { get; set; }
    }
}