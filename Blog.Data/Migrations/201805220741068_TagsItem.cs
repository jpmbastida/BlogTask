namespace Blog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagsItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Tags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Tags");
        }
    }
}
