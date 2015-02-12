namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAll : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Body", c => c.String());
        }
    }
}
