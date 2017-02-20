namespace Fuel.DAL.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithRefueling : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Refuelings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Refuelings", "CarId", "dbo.Cars");
            DropIndex("dbo.Refuelings", new[] { "CarId" });
            DropTable("dbo.Refuelings");
        }
    }
}
