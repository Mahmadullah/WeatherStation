namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityDropdownToCreatePost2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "City_CityId", "dbo.Cities");
            DropIndex("dbo.Posts", new[] { "City_CityId" });
            RenameColumn(table: "dbo.Posts", name: "City_CityId", newName: "CityId");
            AlterColumn("dbo.Posts", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "CityId");
            AddForeignKey("dbo.Posts", "CityId", "dbo.Cities", "CityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CityId", "dbo.Cities");
            DropIndex("dbo.Posts", new[] { "CityId" });
            AlterColumn("dbo.Posts", "CityId", c => c.Int());
            RenameColumn(table: "dbo.Posts", name: "CityId", newName: "City_CityId");
            CreateIndex("dbo.Posts", "City_CityId");
            AddForeignKey("dbo.Posts", "City_CityId", "dbo.Cities", "CityId");
        }
    }
}
