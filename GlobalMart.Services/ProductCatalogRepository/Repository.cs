using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalMart.Services.Models;
using System.Data.Entity.Migrations;

namespace GlobalMart.Services.ProductCatalogRepository
{
    public class Repository : IRepository<Product>
    {

        public Repository() { }
        private IAddExternalService addService;
        public Repository(IAddExternalService service) {
            this.addService = service;
        }


        public virtual bool AddProduct(Product product)
        {
            return this.addService.AddExternalService(product);
        }
        

        public List<Product> GetById(string id)
        {
            using (var productContext = new ProductCatalogContext())
            {
                return productContext.Products.Where(x => x.productId == id).ToList();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var productContext = new ProductCatalogContext())
            {
                return productContext.Products.ToList();
            }
        }

        public bool Remove(string id)
        {
            using (var productContext = new ProductCatalogContext())
            {
                Product prod= productContext.Products.Where(x => x.productId == id).SingleOrDefault();
                productContext.Products.Remove(prod);
                productContext.SaveChanges();
                return true;
            }
        }

        public bool Update(Product product)
        {
            using (var productContext = new ProductCatalogContext())
            {
                productContext.Products.AddOrUpdate(x=>x.productId,product);
                productContext.SaveChanges();
                return true;
            }
        }

        public bool Post(Product product)
        {
            using (var productContext = new ProductCatalogContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();
                return true;
            }
        }
    }
}