namespace GlobalMart.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Price_Catalog", "productId_id", "dbo.Product_Catalog");
            DropIndex("dbo.Price_Catalog", new[] { "productId_id" });
            AddColumn("dbo.Price_Catalog", "PRODUCTID", c => c.String());
            DropColumn("dbo.Price_Catalog", "productId_id");
            DropColumn("dbo.Product_Catalog", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product_Catalog", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Price_Catalog", "productId_id", c => c.Int());
            DropColumn("dbo.Price_Catalog", "PRODUCTID");
            CreateIndex("dbo.Price_Catalog", "productId_id");
            AddForeignKey("dbo.Price_Catalog", "productId_id", "dbo.Product_Catalog", "ID");
        }
    }
}
