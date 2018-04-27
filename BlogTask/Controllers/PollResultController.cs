using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogTask.Models;

namespace BlogTask.Controllers
{
    public class PollResultController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewPollModel vm = new ViewPollModel { PollItems = Polls.AllPolls };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(ViewPollModel vPollModel)
        {
            if (ModelState.IsValid)
            {
                PollItem pollItem = new PollItem() { Genre = vPollModel.Genre, Age = vPollModel.Age, MusicGenres = vPollModel.MusicGenres, Content = vPollModel.Content, Proposals = vPollModel.Proposals };
                Polls.AddPoll(pollItem);
            }
            else
            {
                return View("~/Views/Poll/Index.cshtml", vPollModel);
            }
            vPollModel.PollItems = Polls.AllPolls;
            return View(vPollModel);
        }
    }
}