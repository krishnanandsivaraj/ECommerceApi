using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalMart.Services.Models;
using GlobalMart.Services.ProductCatalogRepository;

namespace GlobalMart.Services.Tests.ProductCatalogRepository
{
    public class TestRepository : IRepository<Product>
    {
        public bool AddProduct(Product product)
        {
            return true;
        }
        List<Product> prod = new List<Product> { new Product { id = 1, Catagories = "Vehicle", productId = "cars01s", brandName = "Maruti", productName = "Suzuki", subCatagories = "Cars" }, new Product { id = 2, Catagories = "Vehicle", productId = "cars02s", brandName = "FIat", productName = "Palio", subCatagories = "Cars" } };

        public List<Product> GetById(string id)
        {
            
                return prod.Where(x => x.productId == id).ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            
                return prod.ToList();
        }

        public bool Remove(string id)
        {
            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }

        public bool Post(Product product)
        {
            throw new NotImplementedException();
        }
    }
}