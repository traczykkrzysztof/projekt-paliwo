namespace Fuel.DAL.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithFuelconsumption : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Refuelings", "Distance", c => c.Single(nullable: false));
            AddColumn("dbo.Refuelings", "Numberofliters", c => c.Single(nullable: false));
            AddColumn("dbo.Refuelings", "Fuelconsumption", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Refuelings", "Fuelconsumption");
            DropColumn("dbo.Refuelings", "Numberofliters");
            DropColumn("dbo.Refuelings", "Distance");
        }
    }
}
