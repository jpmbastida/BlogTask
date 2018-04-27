using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogTask.Models;

namespace BlogTask.Controllers
{
    public class CommentsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewCommentModel vCommentModel = new ViewCommentModel {AllComments = Comment.listComments, Author = ""};
            return View(vCommentModel);
        }

        [HttpPost]
        public ActionResult Index(ViewCommentModel vComment)
        {
            if (ModelState.IsValid)
            {
                CommentItem comment = new CommentItem() {Comment = vComment.Comment, Author = vComment.Author};
                Comment.AddComment(comment);
                vComment.Comment = "";
                vComment.Author = "";
            }
            vComment.AllComments = Comment.listComments;
            return View(vComment);
        }
    }
}