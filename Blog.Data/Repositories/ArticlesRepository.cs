using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Blog.Data.Context;
using Blog.Entities.Articles;
using Blog.Entities.Articles.ViewModels;
using Blog.Entities.Hashtags;

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
        public ArticleViewModel GetArticles()
        {
            using (var context = new BlogContext())
            {
                var articles = context.Articles.ToList();
                var articleViewModel = new ArticleViewModel();

                foreach (var article in articles)
                {
                    articleViewModel.ArticleItems.Add(CleanHashTags(article));
                }
                return articleViewModel;
            }
        }

        /// <summary>
        /// Usage: 
        /// Method for obtaining an Article by Id.
        /// <see cref="GetArticleById(int?)"/> 
        /// </summary>
        /// <returns>An ArticleItem.</returns>
        public Article GetArticleById(int? id)
        {
           using (var context = new BlogContext())
            {
                var article = context.Articles.ToList().Find(i => i.Id == id);
                return article;
            }
        }

        /// <summary>
        /// Usage: 
        /// Method for deleting hashtags in text.
        /// <see cref="CleanHashTags(Article)"/> 
        /// </summary>
        /// <returns>An article item.</returns>
        public static ArticleItem CleanHashTags(Article article)
        {
            return new ArticleItem()
            {
                ArticleId = article.Id,
                ArticleTitle = article.ArticleTitle,
                Author = article.Author,
                Time = article.Time,
                ArticleBody = Regex.Replace(article.ArticleBody, "#", ""),
            };
        }

        /// <summary>
        /// Usage: 
        /// Method for getting hashtags words.
        /// <see cref="Hashtags(Article)"/> 
        /// </summary>
        /// <returns>A list of Hashtags.</returns>
        public List<Hashtag> Hashtags(Article article)
        {
            var tagsCounter = TagsCounter(article);
            List<Hashtag> articlesAndTags = tagsCounter.Select(tag => new Hashtag
            {
                HashtagWord = Regex.Replace(tag.Key, "#", ""),
                CountTags = tag.Value,
                ArticleId = article.Id
            }).ToList();

            return articlesAndTags;
        }

        private static Dictionary<string, int> TagsCounter(Article data)
        {
            var tempArticle = data.ArticleBody;
            tempArticle = Regex.Replace(tempArticle, "[,\\.\"]", "").ToLower();

            Dictionary<string, int> tagsCounter = tempArticle.Split(' ')
                .Where(word => word.StartsWith("#"))
                .GroupBy(hashtag => hashtag)
                .ToDictionary(group => group.Key, group => group.Count());

            return tagsCounter;
        }
    }
}
