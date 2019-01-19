using Model.EF;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class EFModelController : Controller
    {
        protected JpData db = new JpData();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}