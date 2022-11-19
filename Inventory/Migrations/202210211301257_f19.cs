namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f19 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "category_ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_ID" });
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SalesMen", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SalesMen", "Phone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.SalesMen", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "category_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Suppliers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Suppliers", "Phone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Suppliers", "Address", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Products", "category_ID");
            AddForeignKey("dbo.Products", "category_ID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_ID" });
            AlterColumn("dbo.Suppliers", "Address", c => c.String());
            AlterColumn("dbo.Suppliers", "Phone", c => c.String());
            AlterColumn("dbo.Suppliers", "Name", c => c.String());
            AlterColumn("dbo.Products", "category_ID", c => c.Int());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.SalesMen", "Address", c => c.String());
            AlterColumn("dbo.SalesMen", "Phone", c => c.String());
            AlterColumn("dbo.SalesMen", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            CreateIndex("dbo.Products", "category_ID");
            AddForeignKey("dbo.Products", "category_ID", "dbo.Categories", "ID");
        }
    }
}
