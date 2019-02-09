using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 言葉PlusController : EFModelController
    {
        //
        // GET: /Admin/言葉Plus/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);
            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.言葉PlusTable.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.言葉PlusTable.Find(Id);
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", model.第課ID);
            return View("Index", model);
        }

        [HttpPost]
        public JsonResult SaveItem(List<言葉PlusTable> list)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                foreach (var item in list)
                {
                    db.言葉PlusTable.Add(item);
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
        public ActionResult Insert(言葉PlusTable model)
        {
            try
            {
                db.言葉PlusTable.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Thêm thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Thêm thất bại!");
            }
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名");

            return View("Index");
        }

        [ValidateInput(false)]
        public ActionResult Update(言葉PlusTable model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Update thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Update thất bại!");
            }
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名");
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.言葉PlusTable.Find(Id);
                db.言葉PlusTable.Remove(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名");

            return View("Index");
        }
    }
}