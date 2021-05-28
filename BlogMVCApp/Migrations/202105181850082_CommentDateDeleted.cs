namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentDateDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "CommentDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false));
        }
    }
}
