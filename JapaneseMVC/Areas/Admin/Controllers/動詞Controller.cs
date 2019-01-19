using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 動詞Controller : EFModelController
    {
        //
        // GET: /Admin/動詞/
        public ActionResult Index()
        {
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名", selectedValue: false);
            ViewBag.GroupName = new SelectList(db.Group動詞, "GroupNameID", "GroupName", selectedValue: false);
            return View();
        }

        public ActionResult Get(int グループID)
        {
            var model = db.N5動詞.Where(p => p.グループID == グループID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.N5動詞.Find(Id);
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名", model.グループID);
            ViewBag.GroupName = new SelectList(db.Group動詞, "GroupNameID", "GroupName", selectedValue: false);
            return View("Index", model);
        }

        [HttpPost]
        public JsonResult SaveItem(List<N5動詞> list)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                foreach (var item in list)
                {
                    db.N5動詞.Add(item);
                }
                db.SaveChanges();
                status = true;
            }
            else
            {
                status = true;
            }
            return new JsonResult { Data = new { status = status } };
        }

        [ValidateInput(false)]
        public ActionResult Insert(N5動詞 model)
        {
            try
            {
                //model.第課ID = int.Parse(Request.Form["第課List"]);
                db.N5動詞.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Thêm thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Thêm thất bại!");
            }
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名");
            ViewBag.GroupName = new SelectList(db.Group動詞, "GroupNameID", "GroupName", selectedValue: false);
            return View("Index");
        }

        [ValidateInput(false)]
        public ActionResult Update(N5動詞 model)
        {
            try
            {
                //model.第課ID = int.Parse(Request.Form["第課List"]);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Update thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Update thất bại!");
            }
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名");
            ViewBag.GroupName = new SelectList(db.Group動詞, "GroupNameID", "GroupName", selectedValue: false);
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.N5動詞.Find(Id);
                db.N5動詞.Remove(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.グループList = new SelectList(db.グループ, "グループID", "グループの名");
            ViewBag.GroupName = new SelectList(db.Group動詞, "GroupNameID", "GroupName", selectedValue: false);
            return View("Index");
        }
    }
}