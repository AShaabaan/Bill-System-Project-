namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseInvoices", "SalesMan_ID", c => c.Int());
            CreateIndex("dbo.PurchaseInvoices", "SalesMan_ID");
            AddForeignKey("dbo.PurchaseInvoices", "SalesMan_ID", "dbo.SalesMen", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseInvoices", "SalesMan_ID", "dbo.SalesMen");
            DropIndex("dbo.PurchaseInvoices", new[] { "SalesMan_ID" });
            DropColumn("dbo.PurchaseInvoices", "SalesMan_ID");
        }
    }
}
