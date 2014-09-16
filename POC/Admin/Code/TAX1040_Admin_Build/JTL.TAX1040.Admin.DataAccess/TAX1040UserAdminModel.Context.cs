﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JTL.TAX1040.Admin.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TAX1040UserAdminDB : DbContext
    {
        public TAX1040UserAdminDB()
            : base("name=TAX1040UserAdminDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<admin_role> admin_role { get; set; }
        public DbSet<user_admin> user_admin { get; set; }
        public DbSet<user_admin_role> user_admin_role { get; set; }
    
        public virtual ObjectResult<usp_get_all_user_admin_Result> usp_get_all_user_admin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_get_all_user_admin_Result>("usp_get_all_user_admin");
        }
    
        public virtual ObjectResult<usp_get_user_admin_by_user_admin_id_Result> usp_get_user_admin_by_user_admin_id(Nullable<long> user_admin_id)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_get_user_admin_by_user_admin_id_Result>("usp_get_user_admin_by_user_admin_id", user_admin_idParameter);
        }
    
        public virtual ObjectResult<usp_get_user_admin_by_username_Result> usp_get_user_admin_by_username(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_get_user_admin_by_username_Result>("usp_get_user_admin_by_username", usernameParameter);
        }
    
        public virtual ObjectResult<usp_get_user_admin_role_by_user_admin_id_Result> usp_get_user_admin_role_by_user_admin_id(Nullable<long> user_admin_id)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_get_user_admin_role_by_user_admin_id_Result>("usp_get_user_admin_role_by_user_admin_id", user_admin_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_is_user_admin_exists(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_is_user_admin_exists", usernameParameter);
        }
    
        public virtual int usp_user_admin_delete(Nullable<long> user_admin_id)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_user_admin_delete", user_admin_idParameter);
        }
    
        public virtual int usp_user_admin_password_update(Nullable<long> user_admin_id, string password)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_user_admin_password_update", user_admin_idParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_user_admin_persist(string username, string password, string salt, string email, Nullable<bool> is_active, Nullable<bool> is_password_change)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("salt", salt) :
                new ObjectParameter("salt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var is_activeParameter = is_active.HasValue ?
                new ObjectParameter("is_active", is_active) :
                new ObjectParameter("is_active", typeof(bool));
    
            var is_password_changeParameter = is_password_change.HasValue ?
                new ObjectParameter("is_password_change", is_password_change) :
                new ObjectParameter("is_password_change", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_user_admin_persist", usernameParameter, passwordParameter, saltParameter, emailParameter, is_activeParameter, is_password_changeParameter);
        }
    
        public virtual int usp_user_admin_role_delete(Nullable<long> user_admin_id)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_user_admin_role_delete", user_admin_idParameter);
        }
    
        public virtual int usp_user_admin_role_persist(Nullable<long> user_admin_id, string role_name)
        {
            var user_admin_idParameter = user_admin_id.HasValue ?
                new ObjectParameter("user_admin_id", user_admin_id) :
                new ObjectParameter("user_admin_id", typeof(long));
    
            var role_nameParameter = role_name != null ?
                new ObjectParameter("role_name", role_name) :
                new ObjectParameter("role_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_user_admin_role_persist", user_admin_idParameter, role_nameParameter);
        }
    }
}