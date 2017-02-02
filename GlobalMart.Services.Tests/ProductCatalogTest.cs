using NUnit.Framework;
using GlobalMart.Services.Models;
using System.Collections.Generic;
using GlobalMart.Services.Controllers;
using GlobalMart.Services.Tests.ProductCatalogRepository;
using Moq;
using GlobalMart.Services.ProductCatalogRepository;

namespace GlobalMart.Services.Tests
{
    [TestFixture]
    public class ProductCatalogTest
    {
       List<Product> prod = new List<Product>();
        Product product = null;
        ProductCatalogController controller = null;
        Mock<IAddExternalService> _moqRepository = new Mock<IAddExternalService>();
        
        [SetUp]
        public void ProductCatalogTestSetUp()
        {
            prod = new List<Product> { new Product { id = 1, Catagories = "Vehicle", productId = "cars01s", brandName = "Maruti", productName = "Suzuki", subCatagories = "Cars" }, new Product { id = 2, Catagories = "Vehicle", productId = "cars02s", brandName = "FIat", productName = "Palio", subCatagories = "Cars" } };
            product = new Product();
            controller = new ProductCatalogController(new TestRepository()){ };
            
        }
        [Test]
        public void GetProductCatalog_Should_Return_All_Products()
        {
            var result = controller.GetAll() as List<Product>;
            Assert.AreEqual(prod.Count, result.Count);
        }

        [Test]
        public void GetProductCatalog_Should_Return__NotApplicable_OnId()
        {
            List<Product> result = controller.Get("123") as List<Product>;
            Assert.AreEqual("Not Applicable", result[0].productId);
        }

        [Test]
        public void GetProductCatalog_Should_Return_ProperValue_OnId()
        {
            List<Product> result = controller.Get("cars01s") as List<Product>;
            Assert.AreEqual("cars01s", result[0].productId);
        }

        [Test]
        public void ProductCatalog_Should_Return_True_For_External_Insert()
        {
            Product prod = new Product { id = 3, Catagories = "Vehicle", productId = "cars01s", brandName = "Maruti", productName = "Suzuki", subCatagories = "Cars" };

            _moqRepository.Setup(x => x.AddExternalService(prod)).Returns(false);

            var moqobj = _moqRepository.Object;

            IAddExternalService products = moqobj;
            IRepository<Product> product = new Repository(moqobj);
            bool actualResult = product.AddProduct(prod);

            Assert.AreEqual(false, actualResult);
            
        }
    }
}
