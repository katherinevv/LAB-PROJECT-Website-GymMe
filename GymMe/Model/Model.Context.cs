﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymMe.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymMe_DatabaseEntities8 : DbContext
    {
        public GymMe_DatabaseEntities8()
            : base("name=GymMe_DatabaseEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MsCart> MsCarts { get; set; }
        public virtual DbSet<MsSupplement> MsSupplements { get; set; }
        public virtual DbSet<MsSupplementType> MsSupplementTypes { get; set; }
        public virtual DbSet<MsUser> MsUsers { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<TransactionHeader> TransactionHeaders { get; set; }
    }
}
