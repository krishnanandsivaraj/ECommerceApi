using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalMart.Services.Entities
{
    [Table("Price_Catalog")]
    public class PriceCatalog
    {
        [Key]
        public int id { get; set; }
        [Column("PRODUCTID")]
        public string productId { get; set; }
        [Column("PRICE")]
        public int price { get; set; }
    }
}