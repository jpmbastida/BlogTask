namespace Blog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleTitle = c.String(maxLength: 50),
                        ArticleBody = c.String(maxLength: 8000, unicode: false),
                        Author = c.String(maxLength: 50),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentBody = c.String(maxLength: 8000, unicode: false),
                        Author = c.String(maxLength: 50),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KindOfContents",
                c => new
                    {
                        KindOfContentsId = c.Int(nullable: false, identity: true),
                        Tech = c.Boolean(nullable: false),
                        Science = c.Boolean(nullable: false),
                        World = c.Boolean(nullable: false),
                        Economics = c.Boolean(nullable: false),
                        Fashion = c.Boolean(nullable: false),
                        Spectacles = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KindOfContentsId);
            
            CreateTable(
                "dbo.MusicGenres",
                c => new
                    {
                        MusicGenresId = c.Int(nullable: false, identity: true),
                        House = c.Boolean(nullable: false),
                        Country = c.Boolean(nullable: false),
                        Rock = c.Boolean(nullable: false),
                        Pop = c.Boolean(nullable: false),
                        Classic = c.Boolean(nullable: false),
                        Ethnic = c.Boolean(nullable: false),
                        Rap = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MusicGenresId);
            
            CreateTable(
                "dbo.Polls",
                c => new
                    {
                        PollId = c.Int(nullable: false, identity: true),
                        Genre = c.Boolean(nullable: false),
                        Age = c.Int(nullable: false),
                        MusicGenresId = c.Int(nullable: false),
                        KindOfContentsId = c.Int(nullable: false),
                        Proposals = c.String(),
                    })
                .PrimaryKey(t => t.PollId)
                .ForeignKey("dbo.KindOfContents", t => t.KindOfContentsId, cascadeDelete: true)
                .ForeignKey("dbo.MusicGenres", t => t.MusicGenresId, cascadeDelete: true)
                .Index(t => t.MusicGenresId)
                .Index(t => t.KindOfContentsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Polls", "MusicGenresId", "dbo.MusicGenres");
            DropForeignKey("dbo.Polls", "KindOfContentsId", "dbo.KindOfContents");
            DropIndex("dbo.Polls", new[] { "KindOfContentsId" });
            DropIndex("dbo.Polls", new[] { "MusicGenresId" });
            DropTable("dbo.Polls");
            DropTable("dbo.MusicGenres");
            DropTable("dbo.KindOfContents");
            DropTable("dbo.Comment");
            DropTable("dbo.Article");
        }
    }
}
