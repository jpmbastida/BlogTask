using System.Web.Mvc;

namespace BlogTask.Controllers
{
    public class PollController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}