using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using ProyectoFinalWeb.Entities;
using System.Net.Http.Json;

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

        public string randomDog()
        {
            using (var client = new HttpClient())
            {
                string url = "https://dog.ceo/api/breeds/image/random";

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content?.ReadAsStringAsync().Result;

                return "No response";
            }
        }

    }
}