using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.Data.Context;
using Blog.Data.Repositories;
using Blog.Entities.Articles;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace BlogTask.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ArticlesManagementController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: ArticlesManagement
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>();

            foreach (var article in db.Articles.ToList())
            {
                var formatedArticle = new Article
                {
                    Id = article.Id,
                    ArticleTitle = article.ArticleTitle,
                    Author = article.Author,
                    Time = article.Time,
                    ArticleBody = article.ArticleBody.Substring(0, article.ArticleBody.IndexOf("/", StringComparison.Ordinal) + 2)
                };
                articles.Add(formatedArticle);
            }

            return View(articles);
        }

        // GET: ArticlesManagement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: ArticlesManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticlesManagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,ArticleTitle,ArticleBody,Author,Time,Tags")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(article);
        }

        // GET: ArticlesManagement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: ArticlesManagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ArticleTitle,ArticleBody,Author,Time,Tags")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        // GET: ArticlesManagement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: ArticlesManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            if (article != null)
            {
                db.Articles.Remove(article);
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult GetTags(string text)
        {
            var repo = new ArticlesRepository();
            List<string> tags = new List<string>();

            foreach (var article in repo.GetAllArticles())
            {
                var tagsInArticle = repo.Hashtags(article);
                foreach (var tag in tagsInArticle)
                {
                    if (!tags.Contains(tag.HashtagWord))
                    {
                        tags.Add(tag.HashtagWord);
                    }
                }
            }

            var word = text.Split(' ').Last();
            var newTags = tags.Where(x => x.ToLower().Contains(word.ToLower())).ToList();

            return Json(newTags, JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
