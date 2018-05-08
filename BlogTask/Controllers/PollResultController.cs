using System.Web.Mvc;
using Blog.Data.Repositories;
using Blog.Entities.Polls.ViewModels;

namespace BlogTask.Controllers
{
    public class PollResultController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var repo = new PollRepository();
            return View(repo.GetAll());
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Genre, Age, MusicGenres, Content, Proposals")] PollViewModel vPollModel)
        {
            var repo = new PollRepository();
            if (ModelState.IsValid)
            {
                repo.SavePoll(vPollModel);
            }
            else
            {
                return View("~/Views/Poll/Index.cshtml", vPollModel);
            }
            return View(repo.GetAll());
        }
    }
}