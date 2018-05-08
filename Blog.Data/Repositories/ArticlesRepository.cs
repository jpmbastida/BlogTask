using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Articles;
using Blog.Entities.Articles.ViewModels;

namespace Blog.Data.Repositories
{
    /// <summary>
    /// Usage: 
    /// Implements the Repository for Polls
    /// This repository includes a method <see cref="GetArticles()"/> for obtaining all articles to show.
    /// </summary>
    public class ArticlesRepository
    {
        /// <summary>
        /// Usage: 
        /// Method for obtaining all Articles to show.
        /// <see cref="GetArticles()"/> 
        /// </summary>
        /// <returns>A list of ArticlesViewModel.</returns>
        public List<ArticleViewModel> GetArticles()
        {
            using (var context = new BlogContext())
            {
                List<Article> articles = new List<Article>();
                articles = context.Articles.ToList();

                if (articles == null) return null;
                List<ArticleViewModel> articlesToDisplay = new List<ArticleViewModel>();
                foreach (var article in articles)
                {
                    var articleToDisplay = new ArticleViewModel()
                    {
                        ArticleId = article.Id,
                        Author = article.Author,
                        ArticleTitle = article.ArticleTitle,
                        Time = article.Time,
                        ArticleBody = article.ArticleBody
                    };
                    articlesToDisplay.Add(articleToDisplay);
                }
                return articlesToDisplay;
            }
        }
    }
}
