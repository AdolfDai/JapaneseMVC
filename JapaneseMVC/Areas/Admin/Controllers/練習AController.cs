using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 練習AController : EFModelController
    {
        //
        // GET: /Admin/練習A/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);
            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.練習A.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.練習A.Find(Id);
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(練習A model)
        {
            try
            {
                var b = model.練習Aの本;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.練習Aの本 = b;
                var a = model.練習Aの答え;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.練習Aの答え = a;

                db.練習A.Add(model);
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
        public ActionResult Update(練習A model)
        {
            try
            {
                var b = model.練習Aの本;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.練習Aの本 = b;
                var a = model.練習Aの答え;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");

                model.練習Aの答え = a;
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
                var model = db.練習A.Find(Id);
                db.練習A.Remove(model);
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