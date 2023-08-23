using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using coffeeshop.Models;

namespace coffeeshop.Dal
{
    public class rdaDal:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().ToTable("tblMenu");
            modelBuilder.Entity<Vip>().ToTable("tblVip");
            modelBuilder.Entity<User>().ToTable("tblUser");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Vip> Vips { get; set; }
        public DbSet<User> Users { get; set; }
    }
}