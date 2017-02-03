using System.Collections.Generic;

namespace GlobalMart.Services.ProductCatalogRepository
{
    public interface IRepository<T> where T:class
    {
        bool AddExternalService(T product);

        bool Post(T product);
        List<T> GetById(string id);
        IEnumerable<T> GetProducts();
        bool Remove(string id);
        bool Update(T product);
    }
}
