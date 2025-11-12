using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using EFWP2.Models;

namespace EFWP2.Data
{
    public class SampleDbContext: DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options)
        { }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId)
                .IsRequired();
        }
    }
}
