using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Articles;
using Blog.Entities.Comments;
using Blog.Entities.Contents;
using Blog.Entities.Polls;

namespace Blog.Data.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Polls> Polls { get; set; }
        public DbSet<MusicGenres> MusicGenres { get; set; }
        public DbSet<KindOfContents> KindOfContents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
