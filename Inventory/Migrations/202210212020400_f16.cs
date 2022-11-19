namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f16 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "category_ID", newName: "CategoryID");
            RenameIndex(table: "dbo.Products", name: "IX_category_ID", newName: "IX_CategoryID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_CategoryID", newName: "IX_category_ID");
            RenameColumn(table: "dbo.Products", name: "CategoryID", newName: "category_ID");
        }
    }
}
