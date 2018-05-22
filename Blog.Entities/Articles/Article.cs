using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Entities.Articles
{
    /// <summary>
    /// Usage: 
    /// This class <c>Article</c> implements the article data model.
    /// </summary>
    public class Article : BaseEntity
    {
        [Required]
        public string ArticleTitle { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string ArticleBody { get; set; }

        public string Tags { get; set; }
    }
}