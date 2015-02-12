namespace bloog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
