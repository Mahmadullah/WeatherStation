namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityDropdownToCreatePost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "City_CityId", c => c.Int());
            CreateIndex("dbo.Posts", "City_CityId");
            AddForeignKey("dbo.Posts", "City_CityId", "dbo.Cities", "CityId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "City_CityId", "dbo.Cities");
            DropIndex("dbo.Posts", new[] { "City_CityId" });
            DropColumn("dbo.Posts", "City_CityId");
        }
    }
}
