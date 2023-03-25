//using ProyectoFinalAPI.App_Start;//
using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Xml;

namespace ProyectoFinalAPI.Models
{
    public class HomeModel
    {
        //TokenGenerator modelToken = new TokenGenerator()//

        public UsuariosEnt ValidarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {

                var datosBD = (from x in conexion.USUARIOS
                               where x.email == entidad.email
                                  && x.password == entidad.password
                               select x).FirstOrDefault();

                if (datosBD != null)
                {
                    UsuariosEnt respuesta = new UsuariosEnt();
                    respuesta.email = datosBD.email;
                    // respuesta.Token = modelToken.GenerateTokenJwt(datosBD.email);
                    return respuesta;
                }

                return null;
            }
        }


        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.RegistrarUsuario(entidad.nombre,entidad.apellido,entidad.edad,entidad.telefono,entidad.email,entidad.usuario,entidad.password,entidad.role);
            }
        }

        public string BuscarCorreo(string correoValidar)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                var respuesta = (from x in conexion.USUARIOS
                                 where x.email == correoValidar
                                 select x).FirstOrDefault();

                if (respuesta == null)
                    return string.Empty;
                else
                {
                    if (respuesta.estado == false)
                        return "Su cuenta de correo se encuentra inactiva.";
                    else
                        return "Su cuenta de correo ya se encuentra registrada.";
                }
            }
        }


    }
}