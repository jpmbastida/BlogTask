using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Data.Repositories;
using Blog.Entities.Articles.ViewModels;

namespace BlogTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            var repo = new ArticlesRepository();
            return View(repo.GetArticles());
        }
    }
}