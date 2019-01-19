using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 文型Controller : EFModelController
    {
        //
        // GET: /Admin/文型/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);

            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.文型.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.文型.Find(Id);
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(文型 model)
        {
            try
            {
                var b = model.文型の本;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.文型の本 = b;
                db.文型.Add(model);
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
        public ActionResult Update(文型 model)
        {
            try
            {
                var b = model.文型の本;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.文型の本 = b;
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
                var model = db.文型.Find(Id);
                db.文型.Remove(model);
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