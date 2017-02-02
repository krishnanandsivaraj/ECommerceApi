namespace GlobalMart.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Price_Catalog",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PRICE = c.Int(nullable: false),
                        productId_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Product_Catalog", t => t.productId_id)
                .Index(t => t.productId_id);
            
            CreateTable(
                "dbo.Product_Catalog",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CATAGORIES = c.String(),
                        SUBCATAGORIES = c.String(),
                        BRANDNAME = c.String(),
                        PRODUCTID = c.String(),
                        PRODUCTNAME = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Price_Catalog", "productId_id", "dbo.Product_Catalog");
            DropIndex("dbo.Price_Catalog", new[] { "productId_id" });
            DropTable("dbo.Product_Catalog");
            DropTable("dbo.Price_Catalog");
        }
    }
}
