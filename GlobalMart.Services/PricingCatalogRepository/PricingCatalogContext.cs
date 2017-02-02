using GlobalMart.Services.Entities;
using System.Data.Entity;

namespace GlobalMart.Services.PricingCatalogRepository
{
    public class PricingCatalogContext : DbContext
    {
        public PricingCatalogContext() : base("ProductCatalogConnection") { }
        public DbSet<PricingCatalog> Price { get; set; }
    }
}