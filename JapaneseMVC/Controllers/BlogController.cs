using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        public ActionResult Index()
        {
            return View();
        }
    }
}