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
    public class PerroService
    {
        public string RandomDog(string raza)
        {
            var razas = new Dictionary<string, string>(){
                {"Bulldog", "bulldog"},
                {"Chihuahua", "chihuahua"},
                {"Cocker", "spaniel-cocker"},
                { "Pastor Alemán", "germanshepherd"},
                { "Bulldog Francés", "bulldog"},
                { "Gran Danés", "dane-great"},
                {"Beagle", "beagle"},
                { "Bulldog Inglés", "bulldog"},
                { "Poodle", "poodle"},
                { "Terrier", "terrier"},
                { "Labrador Retriever", "retriever-golden"}
            };

            using (var client = new HttpClient())
            {
                string url = String.Format("https://dog.ceo/api/breed/{0}/images/random", razas[raza]);

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["Token"].ToString());
                HttpResponseMessage respuesta = client.GetAsync(url).GetAwaiter().GetResult();

                if (respuesta.IsSuccessStatusCode)
                {
                    string jsonResponse = respuesta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var data = JsonSerializer.Deserialize<DogsFotoEnt>(jsonResponse);
                    return data.message;
                }

                return "No response";
            }
        }
    }
}