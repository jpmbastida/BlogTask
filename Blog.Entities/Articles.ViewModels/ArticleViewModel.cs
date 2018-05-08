using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Entities.Articles.ViewModels
{
    /// <summary>
    /// Usage: 
    /// This class <c>ArticleViewModel</c> implements the article data model for the View.
    /// </summary>
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
    }
}