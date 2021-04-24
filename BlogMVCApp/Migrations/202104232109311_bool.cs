namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _bool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsAuthor", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsAuthor", c => c.String());
        }
    }
}
