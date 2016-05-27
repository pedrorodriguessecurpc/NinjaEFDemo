namespace Konoha.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClanName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Justus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ElementType = c.Int(nullable: false),
                        Shinobi_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shinobis", t => t.Shinobi_Id, cascadeDelete: true)
                .Index(t => t.Shinobi_Id);
            
            CreateTable(
                "dbo.Shinobis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsKonohaShinobi = c.Boolean(nullable: false),
                        ClanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clans", t => t.ClanId, cascadeDelete: true)
                .Index(t => t.ClanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Justus", "Shinobi_Id", "dbo.Shinobis");
            DropForeignKey("dbo.Shinobis", "ClanId", "dbo.Clans");
            DropIndex("dbo.Shinobis", new[] { "ClanId" });
            DropIndex("dbo.Justus", new[] { "Shinobi_Id" });
            DropTable("dbo.Shinobis");
            DropTable("dbo.Justus");
            DropTable("dbo.Clans");
        }
    }
}
