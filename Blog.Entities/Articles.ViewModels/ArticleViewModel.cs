using System.Collections.Generic;
using Blog.Entities.PublicPolls;

namespace Blog.Entities.Articles.ViewModels
{
    /// <summary>
    /// Usage: 
    /// This class <c>ArticleViewModel</c> implements the article data model for the View.
    /// </summary>
    public class ArticleViewModel
    {
        public PublicPoll PublicPolls { get; set; }

        public List<ArticleItem> ArticleItems = new List<ArticleItem>();
    }
}