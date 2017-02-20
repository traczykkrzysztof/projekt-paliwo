namespace Fuel.DAL.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextServiceAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "NextService", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "NextService");
        }
    }
}
