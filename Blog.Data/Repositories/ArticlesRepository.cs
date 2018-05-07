using System.Collections.Generic;
using System.Linq;
using Blog.Data.Context;
using Blog.Entities.Articles;
using Blog.Entities.Articles.ViewModels;

namespace Blog.Data.Repositories
{
    public class ArticlesRepository
    {
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
