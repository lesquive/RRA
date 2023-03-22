using ProyectoFinalAPI.Entities;
using ProyectoFinalAPI.ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalAPI.Models
{
    public class AnimalesModel
    {
        public List<AnimalesEnt> ConsultarAnimalesParaAdopcion()
        {
            using (var conexion = new Proyecto_FinalEntities())
            {
                List<AnimalesEnt> respuesta = new List<AnimalesEnt>();
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
                            imagen_URL = item.imagen_URL,
    });
                    }
                }

                return respuesta;
            }
        }
    }
}