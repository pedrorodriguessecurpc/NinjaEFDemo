namespace Konoha.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedClanName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clans", "Name", c => c.String());
            DropColumn("dbo.Clans", "ClanName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clans", "ClanName", c => c.String());
            DropColumn("dbo.Clans", "Name");
        }
    }
}
