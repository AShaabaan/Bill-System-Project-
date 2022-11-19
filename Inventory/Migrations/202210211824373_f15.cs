namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f15 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products");
            DropIndex("dbo.PurchaseInvoices", new[] { "product_ID" });
            AlterColumn("dbo.PurchaseInvoices", "product_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.PurchaseInvoices", "product_ID");
            AddForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products");
            DropIndex("dbo.PurchaseInvoices", new[] { "product_ID" });
            AlterColumn("dbo.PurchaseInvoices", "product_ID", c => c.Int());
            CreateIndex("dbo.PurchaseInvoices", "product_ID");
            AddForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products", "ID");
        }
    }
}
