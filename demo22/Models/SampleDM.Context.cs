﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo22.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DirectorsDBContext : DbContext
    {
        public DirectorsDBContext()
            : base("name=DirectorsDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DirectorName1> DirectorName1 { get; set; }
        public virtual DbSet<Grouping> Groupings { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<DirectorQualification> DirectorQualifications { get; set; }
    }
}
