using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;

namespace JapaneseMVC.Controllers
{
    public class JpIndexController : EFModelController
    {
        public ActionResult Index(int? Id = 1)
        {

            //第課 --> Lấy ra audio Kotoba, kaiwa, bunkei, reibun, tên daika và chủ đề daika
            ViewBag.list第課 = db.第課_Table.Where(p => p.第課ID == Id).ToList();
            //会話 --> Lấy ra kaiwa.
            ViewBag.list会話 = db.会話_Table.Where(p => p.第課ID == Id).ToList();

            //言葉 --> Lấy ra Kotoba, Kotoba Plus và Audio Kotoba đi kèm ứng với Daika
            ViewBag.list言葉 = db.言葉_Table.Where(p => p.第課ID == Id).ToList();
            ViewBag.list言葉Plus = db.言葉Plus_Table.Where(p => p.第課ID == Id).ToList();

            //文型 --> Lấy ra bunkei.
            ViewBag.list文型 = db.文型_Table.Where(p => p.第課ID == Id).ToList();
            //例文 --> Lấy ra reibun.
            ViewBag.list例文 = db.例文_Table.Where(p => p.第課ID == Id).ToList();

            //練習A --> Lấy ra renshuuA.
            ViewBag.list練習A = db.練習A_Table.Where(p => p.第課ID == Id).ToList();

            //練習B --> Lấy ra renshuuB.


            ViewBag.練習B = db.練習Ｂ_Table.Where(p => p.第課ID == Id).ToList();

            //練習C --> Lấy ra renshuuC.
            ViewBag.練習C = db.練習C_Table.Where(p => p.第課ID == Id).ToList();

            //問題 --> Lấy ra mondai có audio và không video
            ViewBag.問題1 = db.問題_Table.Where(p => p.第課ID == Id && p.問題Audio != "No Audio File").ToList();
            ViewBag.問題2 = db.問題_Table.Where(p => p.第課ID == Id && p.問題Audio == "No Audio File").ToList();

            //Grammar --> Lấy ra Grammar
            ViewBag.Grammar = db.GrammarNihongoes.Where(p => p.第課ID == Id).ToList();

            return View();
        }


      
        public ActionResult GetRenshuuA(int renshuuAId)
        {
            var model = db.練習A_Table.Where(p => p.練習AID == renshuuAId).ToList();
            return PartialView("_ListRenshuuA", model);
        }
        public ActionResult GetRenshuuB(int renshuuBId)
        {
            var model = db.練習Ｂ_Table.Where(p => p.練習ＢID == renshuuBId).ToList();
            return PartialView("_ListRenshuuB", model);
        }
        public ActionResult GetRenshuuC(int renshuuCId)
        {
            var model = db.練習C_Table.Where(p => p.練習CID == renshuuCId).ToList();
            return PartialView("_ListRenshuuC", model);
        }
        public ActionResult GetMondaiAudio(int MondaiId)
        {
            var model = db.問題_Table.Where(p => p.問題ID == MondaiId && p.問題Audio != "No Audio File").ToList();
            return PartialView("_ListMondai", model);
        }
        public ActionResult GetMondaiNoAudio(int MondaiId)
        {
            var model = db.問題_Table.Where(p => p.問題ID == MondaiId && p.問題Audio == "No Audio File").ToList();
            return PartialView("_ListMondaiNoAudio", model);
        }
    }
}