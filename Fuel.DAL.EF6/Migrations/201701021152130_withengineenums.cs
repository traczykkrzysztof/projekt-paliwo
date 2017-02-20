namespace Fuel.DAL.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class withengineenums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "EngineType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "EngineType");
        }
    }
}
