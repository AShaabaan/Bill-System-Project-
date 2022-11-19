namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Invoices", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "Quantity", c => c.Int());
        }
    }
}
