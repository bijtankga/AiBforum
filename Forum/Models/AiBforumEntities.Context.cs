﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Forum.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AiBEntities : DbContext
    {
        public AiBEntities()
            : base("name=AiBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
    }
}
