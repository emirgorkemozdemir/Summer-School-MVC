﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yaz_Okulu_MVC_2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YazOkuluVeritabanıEntities : DbContext
    {
        public YazOkuluVeritabanıEntities()
            : base("name=YazOkuluVeritabanıEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BasvuruTablosu> BasvuruTablosu { get; set; }
        public virtual DbSet<DersTablosu> DersTablosu { get; set; }
        public virtual DbSet<ÖğrenciTablosu> ÖğrenciTablosu { get; set; }
        public virtual DbSet<ÖğretmenTablosu> ÖğretmenTablosu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
