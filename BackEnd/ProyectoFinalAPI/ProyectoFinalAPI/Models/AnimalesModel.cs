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

namespace ProyectoFinalAPI.Models
{
    public class AnimalesModel
    {

        public List<AnimalesEnt> ConsultarAnimalesParaAdopcion()
        {
            using (var conexion = new Proyecto_FinalEntities())
    

            {
                List<AnimalesEnt> respuesta = new List<AnimalesEnt>();
                PerroService perroService = new PerroService();
                GatoService gatoService = new GatoService();
                var datosBD = conexion.ANIMALES_NOT_IN_ADOPCIONES().ToList();

                if (datosBD.Count > 0)
                { 
                    foreach (var item in datosBD)
                    {
                        respuesta.Add(new AnimalesEnt
                        {
                            id = item.id,
                            nombre = item.nombre,
                            especie = item.especie,
                            raza = item.raza,
                            edad = (int)item.edad,
                            estado_salud = item.estado_salud,
                            refugio_ID = (int)item.refugio_ID,
                            imagen_URL = item.especie == "Perro" ? perroService.RandomDog(item.raza) : item.especie == "Gato" ? gatoService.RandomCat() : "Blank"
    });
                    }
                }

                return respuesta;
            }
        }

        public List<TestimoniosEnt> ConsultarTestimonios()
        {
            using (var conexion = new Proyecto_FinalEntities())


            {
                List<TestimoniosEnt> respuesta = new List<TestimoniosEnt>();
                var datosBD = conexion.ConsultarTestimonios().ToList();

                if (datosBD.Count > 0)
                {
                    foreach (var item in datosBD)
                    {
                        respuesta.Add(new TestimoniosEnt
                        {
                            nombre = item.nombre,
                            apellido = item.apellido,
                            mensaje = item.mensaje,
                            //imagen_URL = item.especie == "Perro" ? perroService.RandomDog(item.raza) : item.especie == "Gato" ? gatoService.RandomCat() : "Blank"
                        });
                    }
                }

                return respuesta;
            }
        }
    }
}