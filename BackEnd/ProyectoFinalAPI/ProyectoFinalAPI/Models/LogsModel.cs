using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Json;
using System.Text.Json;
using ProyectoFinalAPI.Servicios;
using System.Configuration;
using System.Net.Mail;

namespace ProyectoFinalAPI.Models
{
    public class LogsModel
    {
        public void EnviarCorreo(string Destinatario, string Asunto, string Body)
        {
            string correoSMTP = ConfigurationManager.AppSettings["correoSMTP"].ToString();
            string claveSMTP = ConfigurationManager.AppSettings["claveSMTP"].ToString();

            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(Destinatario, "User"));
            msg.From = new MailAddress(correoSMTP, "Admin");
            msg.Subject = Asunto;
            msg.Body = Body;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(correoSMTP, claveSMTP);
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Send(msg);
        }

        public void GenerarContrasenna(UsuariosEnt entidad, string resulString)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                var respuesta = (from x in conexion.USUARIOS
                                 where x.email == entidad.email
                                 select x).FirstOrDefault();

                if (respuesta != null)
                {
                    respuesta.password = resulString;
                    conexion.SaveChanges();
                }
            }
        }

        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                var respuesta = (from x in conexion.USUARIOS
                                 where x.email == entidad.email
                                 select x).FirstOrDefault();

                if (respuesta != null)
                {
                    respuesta.password = entidad.NuevaContrasenna;
                    conexion.SaveChanges();
                }
            }
        }
    }
}