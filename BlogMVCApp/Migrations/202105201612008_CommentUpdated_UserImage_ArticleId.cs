namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentUpdated_UserImage_ArticleId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Comments", "UserImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "UserImage");
            DropColumn("dbo.Comments", "Name");
        }
    }
}
