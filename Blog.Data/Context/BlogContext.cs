using System.Data.Entity;
using Blog.Entities.Articles;
using Blog.Entities.Authentication;
using Blog.Entities.Comments;
using Blog.Entities.Polls;
using Blog.Entities.PublicPolls;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Data.Context
{
    /// <inheritdoc />
    /// <summary>
    /// This class <c>BlogContext</c> pass the name of connection string in the BlogTask.web.config and Blog.Data.App.config
    /// or
    /// Explicitly declare the connection string to DB
    /// </summary>
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Entities are declared here 
        /// i.e. physical tables in the DB
        /// </summary>
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Polls> Polls { get; set; }
        public DbSet<PublicPoll> PublicPolls { get; set; }

        public BlogContext()
            : base("BlogContext", throwIfV1Schema: false)
        {
        }

        public static BlogContext Create()
        {
            return new BlogContext();
        }
    }
}
