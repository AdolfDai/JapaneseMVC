using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JapaneseMVC.Controllers;
using Model.EF;

namespace JapaneseMVC.Controllers
{
    public class 漢字Controller : EFModelController
    {
        //
        // GET: /漢字/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", selectedValue: "1");
            return View();
        }
        public ActionResult Get漢字(int 第課ID)
        {
            var model = db.漢字___Table.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List漢字", model);
        }
    }
}