using GlobalMart.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart.Services.ProductCatalogRepository
{
    public interface IAddExternalService
    {
        bool AddExternalService(Product product);
    }
}
