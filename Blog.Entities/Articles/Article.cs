using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Web;

namespace Blog.Entities.Articles
{
    public class Article : BaseEntity
    {
        public string ArticleTitle { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string ArticleBody { get; set; }
    }
}