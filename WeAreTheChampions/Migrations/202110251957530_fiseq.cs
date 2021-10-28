namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fiseq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 50),
                        Red = c.Int(nullable: false),
                        Green = c.Int(nullable: false),
                        Blue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(nullable: false),
                        Score1 = c.Int(),
                        Score2 = c.Int(),
                        Result = c.Int(),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id, cascadeDelete: false)
                .ForeignKey("dbo.Teams", t => t.Team2Id, cascadeDelete: false)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(),
                        PlayerName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Tables", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Tables", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Tables", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Tables", new[] { "Team_Id" });
            DropIndex("dbo.Tables", new[] { "Team2Id" });
            DropIndex("dbo.Tables", new[] { "Team1Id" });
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropTable("dbo.Players");
            DropTable("dbo.Tables");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamColors");
            DropTable("dbo.Colors");
        }
    }
}
