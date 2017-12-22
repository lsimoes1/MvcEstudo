using System.Web.Mvc;

namespace TemplateMVCCurric.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}