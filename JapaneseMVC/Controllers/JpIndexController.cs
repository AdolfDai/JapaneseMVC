using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class JpIndexController : EFModelController
    {
        [ActionName("みんなの日本語")]
        public ActionResult Index(int? 第課 = 1)
        {
            //第課 --> Lấy ra audio Kotoba, kaiwa, bunkei, reibun, tên daika và chủ đề daika
            ViewBag.list第課 = db.第課.Where(p => p.第課ID == 第課).ToList();
            //会話 --> Lấy ra kaiwa.
            ViewBag.list会話 = db.会話.Where(p => p.第課ID == 第課).ToList();

            //言葉 --> Lấy ra Kotoba, Kotoba Plus và Audio Kotoba đi kèm ứng với Daika
            ViewBag.list言葉 = db.言葉Table.Where(p => p.第課ID == 第課).ToList();
            ViewBag.list言葉Plus = db.言葉PlusTable.Where(p => p.第課ID == 第課).ToList();

            //文型 --> Lấy ra bunkei.
            ViewBag.list文型 = db.文型.Where(p => p.第課ID == 第課).ToList();
            //例文 --> Lấy ra reibun.
            ViewBag.list例文 = db.例文.Where(p => p.第課ID == 第課).ToList();

            //練習A --> Lấy ra renshuuA.
            ViewBag.list練習A = db.練習A.Where(p => p.第課ID == 第課).ToList();

            //練習B --> Lấy ra renshuuB.

            ViewBag.練習B = db.練習B.Where(p => p.第課ID == 第課).ToList();

            //練習C --> Lấy ra renshuuC.
            ViewBag.練習C = db.練習C.Where(p => p.第課ID == 第課).ToList();

            //問題 --> Lấy ra mondai có audio và không video
            ViewBag.問題 = db.問題.Where(p => p.第課ID == 第課).ToList();

            //Grammar --> Lấy ra Grammar
            ViewBag.Grammar = db.GrammarNihongoes.Where(p => p.第課ID == 第課).ToList();

            return View("Index");
        }

        public ActionResult GetRenshuuA(int renshuuAId)
        {
            var model = db.練習A.Where(p => p.Id == renshuuAId).ToList();
            return PartialView("_ListRenshuuA", model);
        }

        public ActionResult GetRenshuuB(int renshuuBId)
        {
            var model = db.練習B.Where(p => p.練習BID == renshuuBId).ToList();
            return PartialView("_ListRenshuuB", model);
        }

        public ActionResult GetRenshuuC(int renshuuCId)
        {
            var model = db.練習C.Where(p => p.練習CID == renshuuCId).ToList();
            return PartialView("_ListRenshuuC", model);
        }

        public ActionResult GetMondai(int MondaiId)
        {
            var model = db.問題.Where(p => p.問題ID == MondaiId).ToList();
            return PartialView("_ListMondai", model);
        }
    }
}