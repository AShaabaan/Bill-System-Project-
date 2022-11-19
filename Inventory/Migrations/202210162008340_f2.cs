namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvoiceProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Invoice_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.Invoice_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Invoice_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.InvoiceProducts", "Invoice_ID", "dbo.Invoices");
            DropIndex("dbo.InvoiceProducts", new[] { "Product_ID" });
            DropIndex("dbo.InvoiceProducts", new[] { "Invoice_ID" });
            DropTable("dbo.InvoiceProducts");
        }
    }
}
