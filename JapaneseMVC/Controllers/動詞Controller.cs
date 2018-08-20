using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JapaneseMVC.Controllers;
using Model.EF;

namespace JapaneseMVC.Controllers
{
    public class 動詞Controller : EFModelController
    {
        //
        // GET: /動詞/
        public ActionResult Index()
        {
            ViewBag.グループList = new SelectList(db.グループ_Table, "グループID", "グループ", selectedValue:"1");
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View();
        }
        public ActionResult Get動詞(int グループID)
        {
            var model = db.N5動詞_Table.Where(p => p.グループID == グループID).ToList();
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return PartialView("_List", model);
        }

        public ActionResult GetByGroupName(int groupId , int グループID)
        {
            var model = db.N5動詞_Table.Where(x => x.GroupNameID == groupId && x.グループID == グループID).ToList();
            return PartialView("_List", model);
        }
    }
}