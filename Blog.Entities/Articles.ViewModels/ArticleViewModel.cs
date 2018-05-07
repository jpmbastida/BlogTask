using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Articles.ViewModels
{
    public class ArticleViewModel
    {
        public int ArticleId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime Time { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Title")]
        public string ArticleTitle { get; set; }

        [Display(Name = "Article")]
        public string ArticleBody { get; set; }

        public List<Article> AllArticles = new List<Article>();
    }
}