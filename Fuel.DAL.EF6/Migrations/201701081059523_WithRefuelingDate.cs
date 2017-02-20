namespace Fuel.DAL.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithRefuelingDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Refuelings", "RefuelingDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Refuelings", "RefuelingDate");
        }
    }
}
