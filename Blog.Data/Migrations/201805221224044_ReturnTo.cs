namespace Blog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnTo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "ArticleTitle", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "ArticleTitle", c => c.String(nullable: false));
        }
    }
}
