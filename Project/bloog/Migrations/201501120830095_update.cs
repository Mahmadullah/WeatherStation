namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sys_Country = c.String(),
                        Main_Temp = c.Single(nullable: false),
                        Main_Humidity = c.Int(nullable: false),
                        Main_Pressure = c.Int(nullable: false),
                        Main_Temp_min = c.Single(nullable: false),
                        Main_Temp_max = c.Single(nullable: false),
                        Coord_Lon = c.String(),
                        Coord_Lat = c.String(),
                        Wind_Speed = c.Int(nullable: false),
                        Weather_Description = c.String(),
                    })
                .PrimaryKey(t => t.TestId);
            
        }
    }
}
