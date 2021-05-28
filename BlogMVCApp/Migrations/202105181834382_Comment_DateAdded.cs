namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comment_DateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "CommentDate");
        }
    }
}
