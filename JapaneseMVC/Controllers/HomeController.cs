using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class HomeController : EFModelController
    {
        [ActionName("welcome")]
        [HandleError(View= "Error.cshtml")]
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult _N5第課Category()
        {
            var model = db.第課.ToList();
            return PartialView("N5Template/_N5第課Category", model);
        }

        public ActionResult かなとはく()
        {
            //table1
            ViewBag.Item1 = db.かなとはく.Where(p => p.ColumnWord == 1).ToList();
            ViewBag.Item2 = db.かなとはく.Where(p => p.ColumnWord == 2).ToList();
            ViewBag.Item3 = db.かなとはく.Where(p => p.ColumnWord == 3).ToList();
            ViewBag.Item4 = db.かなとはく.Where(p => p.ColumnWord == 4).ToList();
            ViewBag.Item5 = db.かなとはく.Where(p => p.ColumnWord == 5).ToList();
            ViewBag.Item6 = db.かなとはく.Where(p => p.ColumnWord == 6).ToList();
            ViewBag.Item7 = db.かなとはく.Where(p => p.ColumnWord == 7).ToList();
            ViewBag.Item8 = db.かなとはく.Where(p => p.ColumnWord == 8).ToList();
            ViewBag.Item9 = db.かなとはく.Where(p => p.ColumnWord == 9).ToList();
            ViewBag.Item10 = db.かなとはく.Where(p => p.ColumnWord == 10).ToList();
            ViewBag.Item11 = db.かなとはく.Where(p => p.ColumnWord == 11).ToList();
            //table2
            ViewBag.Item12 = db.かなとはく.Where(p => p.ColumnWord == 12).ToList();
            ViewBag.Item13 = db.かなとはく.Where(p => p.ColumnWord == 13).ToList();
            ViewBag.Item14 = db.かなとはく.Where(p => p.ColumnWord == 14).ToList();
            ViewBag.Item15 = db.かなとはく.Where(p => p.ColumnWord == 15).ToList();
            ViewBag.Item16 = db.かなとはく.Where(p => p.ColumnWord == 16).ToList();
            //table3
            ViewBag.Item17 = db.かなとはく.Where(p => p.ColumnWord == 17).ToList();
            ViewBag.Item18 = db.かなとはく.Where(p => p.ColumnWord == 18).ToList();
            ViewBag.Item19 = db.かなとはく.Where(p => p.ColumnWord == 19).ToList();
            ViewBag.Item20 = db.かなとはく.Where(p => p.ColumnWord == 20).ToList();
            ViewBag.Item21 = db.かなとはく.Where(p => p.ColumnWord == 21).ToList();
            ViewBag.Item22 = db.かなとはく.Where(p => p.ColumnWord == 22).ToList();
            ViewBag.Item23 = db.かなとはく.Where(p => p.ColumnWord == 23).ToList();
            //table4
            ViewBag.Item24 = db.かなとはく.Where(p => p.ColumnWord == 24).ToList();
            ViewBag.Item25 = db.かなとはく.Where(p => p.ColumnWord == 25).ToList();
            ViewBag.Item26 = db.かなとはく.Where(p => p.ColumnWord == 26).ToList();
            ViewBag.Item27 = db.かなとはく.Where(p => p.ColumnWord == 27).ToList();
            return View();
        }
    }
}