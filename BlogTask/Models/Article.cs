using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BlogTask.Models
{
    public class Article
    {
        public string AuthorName { get; set; }
        public DateTime PublishedTime { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleBody { get; set; }
    }
}