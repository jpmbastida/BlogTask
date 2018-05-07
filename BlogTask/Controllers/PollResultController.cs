using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Data.Repositories;
using Blog.Entities.Polls;
using Blog.Entities.Polls.ViewModels;

namespace BlogTask.Controllers
{
    public class PollResultController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //PollViewModel vmPolls = new PollViewModel { PollItems = PollsHelper.AllPolls };
            var repo = new PollRepository();
            return View(repo.GetAll());
        }

        [HttpPost]
        public ActionResult Index(PollViewModel vPollModel)
        {
            var repo = new PollRepository();
            if (ModelState.IsValid)
            {
                //PollItem pollItem = new PollItem() { Genre = vPollModel.Genre, Age = vPollModel.Age, MusicGenres = vPollModel.MusicGenres, Content = vPollModel.Content, Proposals = vPollModel.Proposals };
                //PollsHelper.AddPoll(pollItem);


                repo.SaveComment(vPollModel);
            }
            else
            {
                return View("~/Views/Poll/Index.cshtml", vPollModel);
            }
            //vPollModel.PollItems = PollsHelper.AllPolls;
            return View(repo.GetAll());
        }
    }
}