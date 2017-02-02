using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalMart.Services.Models;
using System.Data.Entity.Migrations;
using GlobalMart.Services.Entities;
using GlobalMart.Services.ProductCatalogRepository;

namespace GlobalMart.Services.PricingCatalogRepository
{
    public class PriceRepository : IRepository<PriceCatalog>
    {
        //Not implemented methods will be considered for future case
        public PriceRepository() { }
        private IAddExternalService addService;
        public PriceRepository(IAddExternalService service)
        {
            this.addService = service;
        }


        public virtual bool AddProduct(PriceCatalog product)
        {
            throw new NotImplementedException();
        }


        public bool Post(PriceCatalog product)
        {
            throw new NotImplementedException();
        }

        List<PriceCatalog> IRepository<PriceCatalog>.GetById(string id)
        {
            using (var productContext = new ProductCatalogContext())
            {
                return productContext.PricingCatalog.Where(x => x.productId == id).ToList();
            }
        }

        public IEnumerable<PriceCatalog> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PriceCatalog product)
        {
            throw new NotImplementedException();
        }
    }
}