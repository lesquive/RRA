using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProyectoFinalWeb.Entities
{
    //Toda las propiedades de un usuario
    public class UsuariosEnt
    {

        public string email { get; set; }

        public string password { get; set; }

        public string ConfirmarContrasenna { get; set; }

        public bool estado { get; set; }

        public string Token { get; set; }
    }
}