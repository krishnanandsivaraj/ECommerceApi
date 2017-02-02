using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GlobalMart.Services.Entities
{
    [Table("Product_Catalog")]
    public class ProductCatalog
    {
        [Column("ID")]
        public int id { get; set; }
        [Column("CATAGORIES")]
        public string Catagories { get; set; }
        [Column("SUBCATAGORIES")]
        public string subCatagories { get; set; }
        [Column("BRANDNAME")]
        public string brandName { get; set; }
        [Column("PRODUCTID")]
        public string productId { get; set; }
        [Column("PRODUCTNAME")]
        public string productName { get; set; }
    }
}