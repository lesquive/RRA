﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProyectoFinalWeb.Entities
{
    //Toda las propiedades de un usuario
    public class UsuariosEnt
    {
        public long id { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }

        public int role { get; set; }

        public string ConfirmarContrasenna { get; set; }

        public bool estado { get; set; }

        public string Token { get; set; }

        public string NuevaContrasenna { get; set; }
    }
}