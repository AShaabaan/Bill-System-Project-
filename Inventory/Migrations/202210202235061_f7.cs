namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Cno");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Cno", c => c.Int(nullable: false));
        }
    }
}
