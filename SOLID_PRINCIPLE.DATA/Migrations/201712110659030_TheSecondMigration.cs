namespace SOLID_PRINCIPLE.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TheSecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Store.Gadgets", "Price", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("Store.Gadgets", "Price", c => c.Decimal(nullable: false, precision: 8, scale: 2));
        }
    }
}
