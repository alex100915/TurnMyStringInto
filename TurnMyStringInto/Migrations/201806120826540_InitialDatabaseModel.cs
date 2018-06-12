namespace TurnMyStringInto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Translation = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        Translated = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Successes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Translations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SuccessId = c.Int(nullable: false),
                        ContentsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contents", t => t.ContentsId, cascadeDelete: true)
                .ForeignKey("dbo.Successes", t => t.SuccessId, cascadeDelete: true)
                .Index(t => t.SuccessId)
                .Index(t => t.ContentsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Translations", "SuccessId", "dbo.Successes");
            DropForeignKey("dbo.Translations", "ContentsId", "dbo.Contents");
            DropIndex("dbo.Translations", new[] { "ContentsId" });
            DropIndex("dbo.Translations", new[] { "SuccessId" });
            DropTable("dbo.Translations");
            DropTable("dbo.Successes");
            DropTable("dbo.Errors");
            DropTable("dbo.Contents");
        }
    }
}
