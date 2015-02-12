namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryPropToCityClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "Country");
        }
    }
}
