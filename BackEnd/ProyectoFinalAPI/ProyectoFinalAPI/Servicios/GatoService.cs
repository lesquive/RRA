using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.Net.Http.Json;
using System.Text.Json;
using ProyectoFinalAPI.Entities;

namespace ProyectoFinalAPI.Servicios
{
    public class GatoService
    {
        public string RandomCat()
        {

            using (var client = new HttpClient())
            {
                string url = "https://cataas.com/cat?json=true";

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                {
                    string jsonResponse = respuesta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonSerializer.Deserialize<CatsFotoEnt>(jsonResponse);
                    return String.Format("https://cataas.com{0}", data.url);
                }

                return "No response";
            }
        }
    }
}