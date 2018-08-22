namespace Coursera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegisterUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Firstname", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Lastname", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Lastname");
            DropColumn("dbo.AspNetUsers", "Firstname");
        }
    }
}
