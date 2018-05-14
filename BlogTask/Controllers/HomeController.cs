using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Blog.Data.Repositories;
using Blog.Entities.Articles.ViewModels;
using Blog.Entities.PublicPolls;

namespace BlogTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            var repo = new ArticlesRepository();
            ArticleViewModel articlesViewModel = repo.GetArticles();

            ArticleViewModel articlesPreviewModel = new ArticleViewModel
            {
                ArticleItems = articlesViewModel.ArticleItems.Select(article =>
                    new ArticleItem
                    {
                        ArticleId = article.ArticleId,
                        ArticleTitle = article.ArticleTitle,
                        Author = article.Author,
                        Time = article.Time,
                        ArticleBody = article.ArticleBody.Substring(0, article.ArticleBody.IndexOf("/", StringComparison.Ordinal) + 2)
                    }
            ).ToList()};

            var repoPoll = new PublicPollRepository();
            articlesPreviewModel.PublicPolls = repoPoll.GetPublicPoll();
            return View(articlesPreviewModel);
        }

        [HttpPost]
        public ActionResult ShowSelectedArticle([Bind(Include = "ArticleId")]int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var repo = new ArticlesRepository();
            var articleResult = repo.GetArticleById(id);
            var articleAndTagsToShow = new ArticleFullViewModel()
            {
                Article = ArticlesRepository.CleanHashTags(articleResult),
                HashtagsList = repo.Hashtags(articleResult)
            };
            return View(articleAndTagsToShow);
        }

        [HttpPost]
        public ActionResult UpdatePoll(string poll)
        {
            var repoPoll = new PublicPollRepository();
            var pollResult = repoPoll.GetPublicPoll();
            
            if (!string.IsNullOrEmpty(poll))
            {
                UpdateOption(ref pollResult, poll);
                repoPoll.UpdatePublicPoll(pollResult);
            }
            return RedirectToAction("Index");
        }

        private static void UpdateOption(ref PublicPoll pollResult, string poll)
        {
            switch (poll)
            {
                case "Tech":
                    pollResult.Tech++;
                    break;
                case "Science":
                    pollResult.Science++;
                    break;
                case "Fashion":
                    pollResult.Fashion++;
                    break;
                case "Photography":
                    pollResult.Photography++;
                    break;
                case "Weather":
                    pollResult.Weather++;
                    break;
            }
        }
    }
}