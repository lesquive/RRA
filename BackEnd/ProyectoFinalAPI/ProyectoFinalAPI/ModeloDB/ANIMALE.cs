//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalAPI.ModeloDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ANIMALE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANIMALE()
        {
            this.ADOPCIONES = new HashSet<ADOPCIONE>();
            this.ADOPCIONES1 = new HashSet<ADOPCIONE>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public Nullable<int> edad { get; set; }
        public string estado_salud { get; set; }
        public Nullable<int> refugio_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADOPCIONE> ADOPCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADOPCIONE> ADOPCIONES1 { get; set; }
        public virtual REFUGIO REFUGIO { get; set; }
    }
}