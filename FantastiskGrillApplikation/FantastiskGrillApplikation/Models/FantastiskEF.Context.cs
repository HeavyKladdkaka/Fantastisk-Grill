﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FantastiskGrillApplikation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FantastiskDatabasEntities : DbContext
    {
        public FantastiskDatabasEntities()
            : base("name=FantastiskDatabasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_HasIngredient> Tbl_HasIngredient { get; set; }
        public virtual DbSet<Tbl_Ingredient> Tbl_Ingredient { get; set; }
        public virtual DbSet<Tbl_Menu> Tbl_Menu { get; set; }
    }
}
