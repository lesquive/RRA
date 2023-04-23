using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProyectoFinalWeb.Entities
{
    //Toda las propiedades de un usuario
    public class VoluntariosEnt
    {
        public long id { get; set; }

        public int voluntario_ID { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string disponibilidad { get; set; }

        public string imagen_URL { get; set; }
    }
}