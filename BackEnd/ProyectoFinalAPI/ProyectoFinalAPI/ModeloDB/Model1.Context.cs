﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Proyecto_FinalEntities1 : DbContext
    {
        public Proyecto_FinalEntities1()
            : base("name=Proyecto_FinalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADOPCIONE> ADOPCIONES { get; set; }
        public virtual DbSet<ANIMALE> ANIMALES { get; set; }
        public virtual DbSet<DONACIONE> DONACIONES { get; set; }
        public virtual DbSet<ERRORE> ERRORES { get; set; }
        public virtual DbSet<IMAGENE> IMAGENES { get; set; }
        public virtual DbSet<REFUGIO> REFUGIOS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<TESTIMONIO> TESTIMONIOS { get; set; }
        public virtual DbSet<USUARIO> USUARIOS { get; set; }
        public virtual DbSet<VOLUNTARIO> VOLUNTARIOS { get; set; }
    }
}
