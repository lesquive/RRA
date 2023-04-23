//using ProyectoFinalAPI.App_Start;//
using ProyectoFinalAPI.App_Start;
using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloDB;
using System;
using System.Linq;

namespace ProyectoFinalAPI.Models
{
    public class HomeModel
    {
        //TokenGenerator modelToken = new TokenGenerator()//
        LogsModel modelLogs = new LogsModel();
        TokenGenerator modelToken = new TokenGenerator(); 
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
                    respuesta.id = datosBD.id;
                    respuesta.email = datosBD.email;
                    respuesta.nombre = datosBD.nombre;
                    respuesta.apellido = datosBD.apellido;
                    respuesta.Token = modelToken.GenerateTokenJwt(datosBD.id.ToString());
                    return respuesta;
                }

                return null;
            }
        }

        public int AdoptarMascota(AdoptarEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.AdoptarMascota(entidad.animal_ID, entidad.adoptante_ID);
            }
        }

        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.RegistrarUsuario(entidad.nombre,entidad.apellido,entidad.edad,entidad.telefono,entidad.email,entidad.usuario,entidad.password, entidad.role);
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

        public void GenerarContrasenna(UsuariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                var respuesta = (from x in conexion.USUARIOS
                                 where x.email == entidad.email
                                 select x).FirstOrDefault();

                if (respuesta != null)
                {

                        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                        var Charsarr = new char[8];
                        var random = new Random();

                        for (int i = 0; i < Charsarr.Length; i++)
                        {
                            Charsarr[i] = characters[random.Next(characters.Length)];
                        }

                        var resultString = new String(Charsarr);


                    modelLogs.GenerarContrasenna(entidad, resultString);
                    string Asunto = "RECUPERAR CONTRASEÑA";
                    string Body = "Su contraseña temporal es: <BR/> " + resultString;
                    modelLogs.EnviarCorreo(entidad.email, Asunto, Body);

                }
            }
        }
        public int AgregarTestimonio(TestimoniosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.AgregarTestimonio(entidad.usuario_id, entidad.mensaje);
            }
        }
        public int Donar(DonacionesEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.Donar(entidad.refugio_ID, entidad.donante_ID, entidad.cantidad);
            }
        }

        public int AgregarVoluntario(VoluntariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                return conexion.AgregarVoluntario(entidad.voluntario_ID, entidad.disponibilidad);
            }
        }
    }
}
