﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrnekCV.Models.entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities1 : DbContext
    {
        public DbCvEntities1()
            : base("name=DbCvEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyim> TblDeneyim { get; set; }
        public virtual DbSet<TblEgitimler> TblEgitimler { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblHobiler> TblHobiler { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblSertifika> TblSertifika { get; set; }
        public virtual DbSet<tblYeteneklerim> tblYeteneklerim { get; set; }
        public virtual DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }
    }
}
