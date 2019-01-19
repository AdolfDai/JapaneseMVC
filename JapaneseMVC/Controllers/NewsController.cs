using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
            return View();
        }
    }
}