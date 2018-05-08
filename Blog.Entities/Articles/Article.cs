using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;

namespace Blog.Entities.Articles
{
    /// <summary>
    /// Usage: 
    /// This class <c>Article</c> implements the article data model.
    /// </summary>
    public class Article : BaseEntity
    {
        public string ArticleTitle { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string ArticleBody { get; set; }
    }
}