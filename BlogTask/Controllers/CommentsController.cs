using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Data.Repositories;
using Blog.Entities.Comments.ViewModels;

namespace BlogTask.Controllers
{
    public class CommentsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var repo = new CommentsRepository();
            return View(repo.GetAll());
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Author, Time, Comment")] CommentViewModel vComment)
        {
            var repo = new CommentsRepository();
            if (ModelState.IsValid)
            {
                if (repo.SaveComment(vComment))
                {
                    return View(repo.GetAll());
                }
            }
           return View(repo.GetAll());
        }
    }
}