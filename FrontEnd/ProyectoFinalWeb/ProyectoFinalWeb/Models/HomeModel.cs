using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using ProyectoFinalWeb.Entities;
using System.Net.Http.Json;
using System.Text.Json;

namespace ProyectoFinalWeb.Models
{
    public class HomeModel
    {
        public List<AnimalesEnt> Adopta()
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44343/api/ConsultarAnimalesParaAdopcion";



                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();



                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<List<AnimalesEnt>>().Result;



                return new List<AnimalesEnt>();
            }
        }

        public string RandomDog()
        {
            using (var client = new HttpClient())
            {
                string url = "https://dog.ceo/api/breeds/image/random";

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                {
                    string jsonResponse = respuesta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonSerializer.Deserialize<dynamic>(jsonResponse);
                    return data["message"];
                }

                return "No response";
            }
        }

        public UsuariosEnt ValidarUsuario(UsuariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343/api/ValidarUsuario";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<UsuariosEnt>().Result;

                return null;
            }
        }


        public int RegistrarUsuario(UsuariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343/api/RegistrarUsuario";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }

        public int IniciarSesion(UsuariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44381/api/RegistrarUsuario";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }
        public string BuscarCorreo(string correoValidar)
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44343/api/BuscarCorreo?correoValidar=" + correoValidar;
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<string>().Result;

                return "ERROR";
            }
        }

        public void RecuperarContrasenna(UsuariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343//api/RecuperarContrasenna";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();
            }
        }
        public List<VoluntariosEnt> ConsultarVoluntarios()
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44343/api/ConsultarVoluntarios";

                //HttpContext.Current.Session["Token"].ToString();
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<List<VoluntariosEnt>>().Result;

                return new List<VoluntariosEnt>();
            }
        }

        public List<TestimoniosEnt> ConsultarTestimonios()
        {
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44343/api/ConsultarTestimonios";

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<List<TestimoniosEnt>>().Result;

                return new List<TestimoniosEnt>();
            }
        }

        public int AgregarTestimonio(TestimoniosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343/api/AgregarTestimonio";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }

        public void GenerarContrasenna(UsuariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343//api/GenerarContrasenna";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();
            }
        }

        public int Donar(DonacionesEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343/api/Donar";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }

        public int AgregarVoluntario(VoluntariosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                JsonContent body = JsonContent.Create(entidad);
                string url = "https://localhost:44343/api/AgregarVoluntario";
                HttpResponseMessage respuesta = client.PostAsync(url, body).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }


    }
}
