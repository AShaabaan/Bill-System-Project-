namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseInvoices", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseInvoices", "Date");
        }
    }
}
