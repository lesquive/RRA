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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.ADOPCIONES = new HashSet<ADOPCIONE>();
            this.ADOPCIONES1 = new HashSet<ADOPCIONE>();
            this.ADOPCIONES2 = new HashSet<ADOPCIONE>();
            this.DONACIONES = new HashSet<DONACIONE>();
            this.DONACIONES1 = new HashSet<DONACIONE>();
            this.DONACIONES2 = new HashSet<DONACIONE>();
            this.IMAGENES = new HashSet<IMAGENE>();
            this.IMAGENES1 = new HashSet<IMAGENE>();
            this.REFUGIOS = new HashSet<REFUGIO>();
            this.REFUGIOS1 = new HashSet<REFUGIO>();
            this.REFUGIOS2 = new HashSet<REFUGIO>();
            this.TESTIMONIOS = new HashSet<TESTIMONIO>();
            this.TESTIMONIOS1 = new HashSet<TESTIMONIO>();
            this.TESTIMONIOS2 = new HashSet<TESTIMONIO>();
            this.VOLUNTARIOS = new HashSet<VOLUNTARIO>();
            this.VOLUNTARIOS1 = new HashSet<VOLUNTARIO>();
            this.VOLUNTARIOS2 = new HashSet<VOLUNTARIO>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> edad { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string usuario1 { get; set; }
        public string password { get; set; }
        public Nullable<int> role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADOPCIONE> ADOPCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADOPCIONE> ADOPCIONES1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADOPCIONE> ADOPCIONES2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONACIONE> DONACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONACIONE> DONACIONES1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONACIONE> DONACIONES2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMAGENE> IMAGENES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMAGENE> IMAGENES1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFUGIO> REFUGIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFUGIO> REFUGIOS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFUGIO> REFUGIOS2 { get; set; }
        public virtual ROLE ROLE1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESTIMONIO> TESTIMONIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESTIMONIO> TESTIMONIOS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESTIMONIO> TESTIMONIOS2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLUNTARIO> VOLUNTARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLUNTARIO> VOLUNTARIOS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOLUNTARIO> VOLUNTARIOS2 { get; set; }
    }
}
