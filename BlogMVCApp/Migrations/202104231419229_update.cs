namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Menus", "ControllerName", c => c.String(nullable: false));
            AddColumn("dbo.Menus", "Order", c => c.Byte(nullable: false));
            AddColumn("dbo.Menus", "ActionName", c => c.String());
            DropColumn("dbo.Menus", "IsAction");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "IsAction", c => c.Boolean(nullable: false));
            DropColumn("dbo.Menus", "ActionName");
            DropColumn("dbo.Menus", "Order");
            DropColumn("dbo.Menus", "ControllerName");
            DropColumn("dbo.Menus", "IsActive");
        }
    }
}
