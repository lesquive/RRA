//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalAPI.ModeloDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADOPCIONES
    {
        public int id { get; set; }
        public Nullable<int> animal_ID { get; set; }
        public Nullable<int> refugio_ID { get; set; }
        public Nullable<int> adoptante_ID { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual ANIMALES ANIMALES { get; set; }
        public virtual REFUGIOS REFUGIOS { get; set; }
    }
}
