using System.Web.Mvc;
using Blog.Data.Repositories;

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