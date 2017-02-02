using GlobalMart.Services.Entities;
using GlobalMart.Services.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace GlobalMart.Services.ProductCatalogRepository
{
    public class ProductCatalogContext : DbContext
    {
        public ProductCatalogContext() : base("ProductCatalogConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<PriceCatalog> PricingCatalog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}