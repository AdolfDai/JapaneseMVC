using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class 漢字Controller : EFModelController
    {
        //
        // GET: /漢字/
        [ActionName("look-and-learn")]
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: "1");
            return View("Index");
        }

        public ActionResult Get漢字(int 第課ID)
        {
            var model = db.漢字.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List漢字", model);
        }
    }
}