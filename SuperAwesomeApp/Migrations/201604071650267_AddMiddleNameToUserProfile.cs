namespace SuperAwesomeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMiddleNameToUserProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "MiddleName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfiles", "MiddleName");
        }
    }
}
