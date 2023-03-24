using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Entities
{
    public class CatsFotoEnt
    {


        public string createdAt { get; set; }

        public string updatedAt { get; set; }

        public string owner { get; set; }

        public string file { get; set; }

        public string mimetype { get; set; }

        public string _id { get; set; }

        public string url { get; set; }

    }
}