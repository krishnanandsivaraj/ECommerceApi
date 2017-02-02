using GlobalMart.Services.Entities;
using GlobalMart.Services.PricingCatalogRepository;
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
    [EnableCors(origins: "http://localhost:35908/", headers: "*", methods: "*")]
    [RoutePrefix("PriceCatalog")]
    public class PriceCatalogController : ApiController
    {
        public IRepository<PriceCatalog> _repository = null;
        private Repository repository;

        public PriceCatalogController():this(new PriceRepository()) { }

        public PriceCatalogController(PriceRepository repository)
        {
            _repository = repository;
        }

        public PriceCatalogController(IRepository<PriceCatalog> repo) { this._repository = repo; }

        [Route("GetPrice/{id}")]
        public IEnumerable<PriceCatalog> Get(string id)
        {
            var repo = _repository.GetById(id);
            return (repo.Count == 0) ? new List<PriceCatalog>() { new PriceCatalog { price = -1 } } : repo.ToList();
        }

    }
}
