namespace Blog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Article", "ArticleTitle", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Article", "ArticleTitle", c => c.String(maxLength: 50));
        }
    }
}
