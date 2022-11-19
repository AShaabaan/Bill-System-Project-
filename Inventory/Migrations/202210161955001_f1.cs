namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Cno = c.Int(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(),
                        Total = c.Decimal(precision: 18, scale: 2),
                        Date = c.DateTime(),
                        Customer_ID = c.Int(),
                        SalesMan_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .ForeignKey("dbo.SalesMen", t => t.SalesMan_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.SalesMan_ID);
            
            CreateTable(
                "dbo.SalesMen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.category_ID)
                .Index(t => t.category_ID);
            
            CreateTable(
                "dbo.PurchaseInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchasingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        product_ID = c.Int(),
                        supplier_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.product_ID)
                .ForeignKey("dbo.Suppliers", t => t.supplier_ID)
                .Index(t => t.product_ID)
                .Index(t => t.supplier_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseInvoices", "supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.PurchaseInvoices", "product_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "category_ID", "dbo.Categories");
            DropForeignKey("dbo.Invoices", "SalesMan_ID", "dbo.SalesMen");
            DropForeignKey("dbo.Invoices", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.PurchaseInvoices", new[] { "supplier_ID" });
            DropIndex("dbo.PurchaseInvoices", new[] { "product_ID" });
            DropIndex("dbo.Products", new[] { "category_ID" });
            DropIndex("dbo.Invoices", new[] { "SalesMan_ID" });
            DropIndex("dbo.Invoices", new[] { "Customer_ID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.PurchaseInvoices");
            DropTable("dbo.Products");
            DropTable("dbo.SalesMen");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
