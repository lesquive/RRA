﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Proyecto_FinalEntities : DbContext
    {
        public Proyecto_FinalEntities()
            : base("name=Proyecto_FinalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADOPCIONES> ADOPCIONES { get; set; }
        public virtual DbSet<ANIMALES> ANIMALES { get; set; }
        public virtual DbSet<DONACIONES> DONACIONES { get; set; }
        public virtual DbSet<ERRORES> ERRORES { get; set; }
        public virtual DbSet<IMAGENES> IMAGENES { get; set; }
        public virtual DbSet<REFUGIOS> REFUGIOS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<TESTIMONIOS> TESTIMONIOS { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VOLUNTARIOS> VOLUNTARIOS { get; set; }
    
        public virtual ObjectResult<ANIMALES_NOT_IN_ADOPCIONES_Result> ANIMALES_NOT_IN_ADOPCIONES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ANIMALES_NOT_IN_ADOPCIONES_Result>("ANIMALES_NOT_IN_ADOPCIONES");
        }
    
        public virtual ObjectResult<ConsultarUsuarios_Result> ConsultarUsuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarUsuarios_Result>("ConsultarUsuarios");
        }
    
        public virtual int RegistrarUsuario(string nombre, string apellido, Nullable<int> edad, string telefono, string email, string usuario, string password, Nullable<int> role)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("edad", edad) :
                new ObjectParameter("edad", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roleParameter = role.HasValue ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarUsuario", nombreParameter, apellidoParameter, edadParameter, telefonoParameter, emailParameter, usuarioParameter, passwordParameter, roleParameter);
        }
    
        public virtual ObjectResult<ValidarUsuario_Result> ValidarUsuario(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidarUsuario_Result>("ValidarUsuario", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<ConsultarVoluntarios_Result> ConsultarVoluntarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarVoluntarios_Result>("ConsultarVoluntarios");
        }
    }
}
