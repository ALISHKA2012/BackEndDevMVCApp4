namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "IsAction", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "IsAction");
        }
    }
}
