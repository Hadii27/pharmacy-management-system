﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaymanStore.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Juxon_storeEntities : DbContext
    {
        public Juxon_storeEntities()
            : base("name=Juxon_storeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Buying_info> Buying_info { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<invoice_info> invoice_info { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
