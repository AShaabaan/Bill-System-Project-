namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceProducts", "Invoice_ID", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceProducts", "Product_ID", "dbo.Products");
            DropIndex("dbo.InvoiceProducts", new[] { "Invoice_ID" });
            DropIndex("dbo.InvoiceProducts", new[] { "Product_ID" });
            RenameColumn(table: "dbo.InvoiceProducts", name: "Invoice_ID", newName: "InvoiceID");
            RenameColumn(table: "dbo.InvoiceProducts", name: "Product_ID", newName: "ProductID");
            DropPrimaryKey("dbo.InvoiceProducts");
            AlterColumn("dbo.InvoiceProducts", "InvoiceID", c => c.Int(nullable: false));
            AlterColumn("dbo.InvoiceProducts", "ProductID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.InvoiceProducts", new[] { "InvoiceID", "ProductID" });
            CreateIndex("dbo.InvoiceProducts", "InvoiceID");
            CreateIndex("dbo.InvoiceProducts", "ProductID");
            AddForeignKey("dbo.InvoiceProducts", "InvoiceID", "dbo.Invoices", "ID", cascadeDelete: true);
            AddForeignKey("dbo.InvoiceProducts", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
            DropColumn("dbo.InvoiceProducts", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoiceProducts", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.InvoiceProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.InvoiceProducts", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.InvoiceProducts", new[] { "ProductID" });
            DropIndex("dbo.InvoiceProducts", new[] { "InvoiceID" });
            DropPrimaryKey("dbo.InvoiceProducts");
            AlterColumn("dbo.InvoiceProducts", "ProductID", c => c.Int());
            AlterColumn("dbo.InvoiceProducts", "InvoiceID", c => c.Int());
            AddPrimaryKey("dbo.InvoiceProducts", "Id");
            RenameColumn(table: "dbo.InvoiceProducts", name: "ProductID", newName: "Product_ID");
            RenameColumn(table: "dbo.InvoiceProducts", name: "InvoiceID", newName: "Invoice_ID");
            CreateIndex("dbo.InvoiceProducts", "Product_ID");
            CreateIndex("dbo.InvoiceProducts", "Invoice_ID");
            AddForeignKey("dbo.InvoiceProducts", "Product_ID", "dbo.Products", "ID");
            AddForeignKey("dbo.InvoiceProducts", "Invoice_ID", "dbo.Invoices", "ID");
        }
    }
}
