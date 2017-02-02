using GlobalMart.Services.Models;
using GlobalMart.Services.ProductCatalogRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GlobalMart.Services.Controllers
{
    [EnableCors(origins: "http://localhost:43708", headers: "*", methods: "*")]
    [RoutePrefix("ProductCatalog")]
    public class ProductCatalogController : ApiController
    {
        public IRepository<Product> _repository = null;
        public ProductCatalogController():this(new Repository()) { }
        public ProductCatalogController(IRepository<Product> repo) { this._repository = repo; }
        
        [Route("GetAllProducts")]
        public IEnumerable<Product> GetAll()
        {
            return _repository.GetProducts();
            
        }

        [Route("GetAllProducts/{id}")]
        public IEnumerable<Product> Get(string id)
        {
            var repo= _repository.GetById(id);
            return (repo.Count==0) ? new List<Product>() { new Product { productId = "Not Applicable" } } : repo.ToList();
        }

        [Route("AddProduct")]
        public string Post([FromBody]Product product)
        {
            bool result = _repository.Post(product);
            return result ? "success" : "failure";
        }

        [Route("UpdateProduct")]
        public string Put([FromBody]Product product)
        {
            bool result = _repository.Update(product);
            return result ? "success" : "failure";
        }

        [Route("DeleteProduct/{id}")]
        [AcceptVerbs("POST", "PUT")]
        public string Delete([FromUri]string id)
        {
            bool result = _repository.Remove(id);
            return result ? "success" : "failure";
        }
    }
    }
