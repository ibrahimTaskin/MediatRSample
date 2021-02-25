using MediatRExample.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Persistence
{
    public class MediatrContext : DbContext
    {
        public MediatrContext(DbContextOptions<MediatrContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "T-Shirt" },
                new Product { Id = 2, ProductName = "Pantolon" },
                new Product { Id = 3, ProductName = "Ceket" }
                );
        }

        public DbSet<Product> Products { get; set; }

    }
}
