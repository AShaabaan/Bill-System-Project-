namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ff1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products");
            DropIndex("dbo.PurchaseInvoices", new[] { "product_ID" });
            CreateTable(
                "dbo.PurchaseInvoiceProducts",
                c => new
                    {
                        PurchaseInvoiceID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        PurchasingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CountofProduct = c.Int(nullable: false),
                        PriceofTotalProduct = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.PurchaseInvoiceID, t.ProductID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.PurchaseInvoices", t => t.PurchaseInvoiceID, cascadeDelete: true)
                .Index(t => t.PurchaseInvoiceID)
                .Index(t => t.ProductID);
            
            AddColumn("dbo.InvoiceProducts", "CountofProduct", c => c.Int(nullable: false));
            AddColumn("dbo.InvoiceProducts", "PriceofTotalProduct", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.InvoiceProducts", "Quantity");
            DropColumn("dbo.PurchaseInvoices", "PurchasingPrice");
            DropColumn("dbo.PurchaseInvoices", "Quantity");
            DropColumn("dbo.PurchaseInvoices", "product_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseInvoices", "product_ID", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseInvoices", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseInvoices", "PurchasingPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InvoiceProducts", "Quantity", c => c.Int(nullable: false));
            DropForeignKey("dbo.PurchaseInvoiceProducts", "PurchaseInvoiceID", "dbo.PurchaseInvoices");
            DropForeignKey("dbo.PurchaseInvoiceProducts", "ProductID", "dbo.Products");
            DropIndex("dbo.PurchaseInvoiceProducts", new[] { "ProductID" });
            DropIndex("dbo.PurchaseInvoiceProducts", new[] { "PurchaseInvoiceID" });
            DropColumn("dbo.InvoiceProducts", "PriceofTotalProduct");
            DropColumn("dbo.InvoiceProducts", "CountofProduct");
            DropTable("dbo.PurchaseInvoiceProducts");
            CreateIndex("dbo.PurchaseInvoices", "product_ID");
            AddForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products", "ID", cascadeDelete: true);
        }
    }
}
