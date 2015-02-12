namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class City : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            DropColumn("dbo.Posts", "City_CityId");
            DropColumn("dbo.Posts", "City_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "City_Name", c => c.String());
            AddColumn("dbo.Posts", "City_CityId", c => c.Int(nullable: false));
            DropTable("dbo.Cities");
        }
    }
}
