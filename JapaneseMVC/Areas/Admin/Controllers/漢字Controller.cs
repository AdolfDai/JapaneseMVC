using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 漢字Controller : EFModelController
    {
        //
        // GET: /Admin/漢字/
        //
        // GET: /Admin/言葉/Partial1
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", selectedValue: false);
            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.漢字___Table.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.漢字___Table.Find(Id);
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", model.第課ID);

            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(漢字___Table model)
        {
            var f = Request.Files["Up漢字Image"];
            if (f.ContentLength > 0)
            {
                model.漢字Image = f.FileName;
                var path漢字Image = Server.MapPath("~/img/漢字/" + model.漢字Image);
                f.SaveAs(path漢字Image);
            }
            else
            {
                model.漢字Image = "noimage.jpg";
            }
            try
            {
                var a = model.例1;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.例1 = a;

                var b = model.例2;
                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");
                model.例2 = b;

                var c = model.Description;
                c = c.Replace("＜", "<ruby>");
                c = c.Replace("＞", "</ruby>");
                c = c.Replace("｛", "<rt>");
                c = c.Replace("｝", "</rt>");
                model.Description = c;

                db.漢字___Table.Add(model);
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
        public ActionResult Update(漢字___Table model)
        {
            var f = Request.Files["Up漢字Image"];
            if (f.ContentLength > 0)
            {
                var path漢字Image = Server.MapPath("~/img/漢字/" + model.漢字Image);
                if (System.IO.File.Exists(path漢字Image))
                {
                    System.IO.File.Delete(path漢字Image);
                    model.漢字Image = f.FileName;
                    path漢字Image = Server.MapPath("~/img/漢字/" + model.漢字Image);
                    f.SaveAs(path漢字Image);
                }
                else
                {
                    model.漢字Image = f.FileName;
                    path漢字Image = Server.MapPath("~/img/漢字/" + model.漢字Image);
                    f.SaveAs(path漢字Image);
                }
            }
            try
            {
                var a = model.例1;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.例1 = a;

                var b = model.例2;
                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");
                model.例2 = b;

                var c = model.Description;
                c = c.Replace("＜", "<ruby>");
                c = c.Replace("＞", "</ruby>");
                c = c.Replace("｛", "<rt>");
                c = c.Replace("｝", "</rt>");
                model.Description = c;

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
                var model = db.漢字___Table.Find(Id);
                db.漢字___Table.Remove(model);
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