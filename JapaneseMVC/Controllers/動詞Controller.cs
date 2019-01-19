using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class 動詞Controller : EFModelController
    {
        //
        // GET: /動詞/
        [ActionName("list-動詞")]
        public ActionResult Index()
        {
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名", selectedValue: "1");
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View("Index");
        }

        public ActionResult Get動詞(int グループID)
        {
            var model = db.N5動詞.Where(p => p.グループID == グループID).ToList();
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return PartialView("_List", model);
        }

        public ActionResult GetByGroupName(int groupId, int グループID)
        {
            var model = db.N5動詞.Where(x => x.GroupNameID == groupId && x.グループID == グループID).ToList();
            return PartialView("_List", model);
        }
    }
}