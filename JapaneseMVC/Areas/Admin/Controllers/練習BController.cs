using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 練習BController : EFModelController
    {
        //
        // GET: /Admin/練習B/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", selectedValue: true);
            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.練習Ｂ_Table.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.練習Ｂ_Table.Find(Id);
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(練習Ｂ_Table model)
        {
            var f = Request.Files["Up練習BImg"];
            if (f.ContentLength > 0)
            {
                model.練習ＢImg = f.FileName;
                var path練習BImg = Server.MapPath("~/img/練習BImg/" + model.練習ＢImg);
                f.SaveAs(path練習BImg);
            }
            else
            {
                model.練習ＢImg = "No Img File";
            }

            try
            {
                var b = model.練習Ｂ;
                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");
                model.練習Ｂ = b;

                var a = model.練習ＢAnswer;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.練習ＢAnswer = a;

                db.練習Ｂ_Table.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Thêm thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Thêm thất bại!");
            }
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name");
            return View("Index");
        }

        [ValidateInput(false)]
        public ActionResult Update(練習Ｂ_Table model)
        {
            var f = Request.Files["Up練習BImg"];
            if (f.ContentLength > 0)
            {
                var path練習BImg = Server.MapPath("~/img/練習BImg/" + model.練習ＢImg);
                if (System.IO.File.Exists(path練習BImg))
                {
                    System.IO.File.Delete(path練習BImg);
                    model.練習ＢImg = f.FileName;
                    path練習BImg = Server.MapPath("~/img/練習BImg/" + model.練習ＢImg);
                    f.SaveAs(path練習BImg);
                }
                else
                {
                    model.練習ＢImg = f.FileName;
                    path練習BImg = Server.MapPath("~/img/練習BImg/" + model.練習ＢImg);
                    f.SaveAs(path練習BImg);
                }
            }

            try
            {
                var b = model.練習Ｂ;
                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");
                model.練習Ｂ = b;

                var a = model.練習ＢAnswer;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.練習ＢAnswer = a;

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Update thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Update thất bại!");
            }
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name");
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.練習Ｂ_Table.Find(Id);
                db.練習Ｂ_Table.Remove(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name");
            return View("Index");
        }
    }
}