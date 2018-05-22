using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Blog.Entities.Articles
{
    /// <summary>
    /// Usage: 
    /// This class <c>Article</c> implements the article data model.
    /// </summary>
    public class Article : BaseEntity
    {
        public string ArticleTitle { get; set; }

        [AllowHtml]
        [Column(TypeName = "VARCHAR")]
        public string ArticleBody { get; set; }

        public string Tags { get; set; }
    }
}