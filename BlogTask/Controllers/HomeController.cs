using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogTask.Models;

namespace BlogTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            MyArticle myarticle = new MyArticle();
            return View(myarticle.myArticles);
        }
    }
}