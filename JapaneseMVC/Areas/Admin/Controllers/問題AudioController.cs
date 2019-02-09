using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 問題AudioController : EFModelController
    {
        //
        // GET: /Admin/問題/
		//
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);
            return View();
        }

        public ActionResult Get問題Audio(int? 第課ID)
        {
            var model = db.問題.Where(p => p.第課ID == 第課ID).ToList();
            ViewBag.問題 = db.問題.Where(p => p.問題Audio != "No Audio File" && p.第課ID == 第課ID).ToList(); 
            return PartialView("_List");
        }
        public ActionResult Edit(int Id)
        {
            var model = db.問題.Find(Id);
            ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(問題 model)
        {
            var f = Request.Files["Up問題Image"];
            if (f.ContentLength > 0)
            {
                model.問題の写真 = f.FileName;
                var path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
                f.SaveAs(path問題Img);
            }
            else
            {
                model.問題の写真 = "headphones.png";
            }
            var f1 = Request.Files["Up問題Audio"];
            if (f1.ContentLength > 0)
            {
                model.問題Audio = f1.FileName;
                var path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
                f1.SaveAs(path問題Audio);
            }
            else
            {
                model.問題Audio = "No Audio File";
            }
            try
            {
                var a = model.問題の本;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.問題の本 = a;

                var b = model.問題1;
                if (b != null)
                {
                    b = b.Replace("＜", "<ruby>");
                    b = b.Replace("＞", "</ruby>");
                    b = b.Replace("｛", "<rt>");
                    b = b.Replace("｝", "</rt>");
                    model.問題1 = b;
                }
                else
                {
                    model.問題1 = b;
                }

                var c = model.問題2;
                if (c != null)
                {
                    c = c.Replace("＜", "<ruby>");
                    c = c.Replace("＞", "</ruby>");
                    c = c.Replace("｛", "<rt>");
                    c = c.Replace("｝", "</rt>");
                    model.問題2 = c;
                }
                else
                {
                    model.問題2 = c;
                }

                var d = model.問題3;
                if (d != null)
                {
                    d = d.Replace("＜", "<ruby>");
                    d = d.Replace("＞", "</ruby>");
                    d = d.Replace("｛", "<rt>");
                    d = d.Replace("｝", "</rt>");
                    model.問題3 = d;
                }
                else
                {
                    model.問題3 = d;
                }

                var e = model.問題4;
                if (e != null)
                {
                    e = e.Replace("＜", "<ruby>");
                    e = e.Replace("＞", "</ruby>");
                    e = e.Replace("｛", "<rt>");
                    e = e.Replace("｝", "</rt>");
                    model.問題4 = e;
                }
                else
                {
                    model.問題4 = e;
                }

                var h = model.問題5;
                if (h != null)
                {
                    h = h.Replace("＜", "<ruby>");
                    h = h.Replace("＞", "</ruby>");
                    h = h.Replace("｛", "<rt>");
                    h = h.Replace("｝", "</rt>");
                    model.問題5 = h;
                }
                else
                {
                    model.問題5 = h;
                }

                var i = model.問題Rei;
                if (i != null)
                {
                    i = i.Replace("＜", "<ruby>");
                    i = i.Replace("＞", "</ruby>");
                    i = i.Replace("｛", "<rt>");
                    i = i.Replace("｝", "</rt>");
                    model.問題Rei = i;
                }
                else
                {
                    model.問題Rei = i;
                }
                var j = model.問題VNIRei;
                if (j != null)
                {
                    j = j.Replace("＜", "<ruby>");
                    j = j.Replace("＞", "</ruby>");
                    j = j.Replace("｛", "<rt>");
                    j = j.Replace("｝", "</rt>");
                    model.問題VNIRei = j;
                }
                else
                {
                    model.問題VNIRei = j;
                }

                db.問題.Add(model);
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
        public ActionResult Update(問題 model)
        {
            var f = Request.Files["Up問題Image"];
            if (f.ContentLength > 0)
            {
                var path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
                if (System.IO.File.Exists(path問題Img))
                {
                    System.IO.File.Delete(path問題Img);
                    model.問題の写真 = f.FileName;
                    path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
                    f.SaveAs(path問題Img);
                }
                else
                {
                    model.問題の写真 = f.FileName;
                    path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
                    f.SaveAs(path問題Img);
                }
            }

            var f1 = Request.Files["Up問題Audio"];
            if (f1.ContentLength > 0)
            {
                var path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
                if (System.IO.File.Exists(path問題Audio))
                {
                    System.IO.File.Delete(path問題Audio);
                    model.問題Audio = f1.FileName;
                    path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
                    f1.SaveAs(path問題Audio);
                }
                else
                {
                    model.問題Audio = f1.FileName;
                    path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
                    f1.SaveAs(path問題Audio);
                }
            }

            try
            {
                var a = model.問題の本;
                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.問題の本 = a;

                var b = model.問題1;
                if (b != null)
                {
                    b = b.Replace("＜", "<ruby>");
                    b = b.Replace("＞", "</ruby>");
                    b = b.Replace("｛", "<rt>");
                    b = b.Replace("｝", "</rt>");
                    model.問題1 = b;
                }
                else
                {
                    model.問題1 = b;
                }

                var c = model.問題2;
                if (c != null)
                {
                    c = c.Replace("＜", "<ruby>");
                    c = c.Replace("＞", "</ruby>");
                    c = c.Replace("｛", "<rt>");
                    c = c.Replace("｝", "</rt>");
                    model.問題2 = c;
                }
                else
                {
                    model.問題2 = c;
                }

                var d = model.問題3;
                if (d != null)
                {
                    d = d.Replace("＜", "<ruby>");
                    d = d.Replace("＞", "</ruby>");
                    d = d.Replace("｛", "<rt>");
                    d = d.Replace("｝", "</rt>");
                    model.問題3 = d;
                }
                else
                {
                    model.問題3 = d;
                }

                var e = model.問題4;
                if (e != null)
                {
                    e = e.Replace("＜", "<ruby>");
                    e = e.Replace("＞", "</ruby>");
                    e = e.Replace("｛", "<rt>");
                    e = e.Replace("｝", "</rt>");
                    model.問題4 = e;
                }
                else
                {
                    model.問題4 = e;
                }

                var h = model.問題5;
                if (h != null)
                {
                    h = h.Replace("＜", "<ruby>");
                    h = h.Replace("＞", "</ruby>");
                    h = h.Replace("｛", "<rt>");
                    h = h.Replace("｝", "</rt>");
                    model.問題5 = h;
                }
                else
                {
                    model.問題5 = h;
                }

                var i = model.問題Rei;
                if (i != null)
                {
                    i = i.Replace("＜", "<ruby>");
                    i = i.Replace("＞", "</ruby>");
                    i = i.Replace("｛", "<rt>");
                    i = i.Replace("｝", "</rt>");
                    model.問題Rei = i;
                }
                else
                {
                    model.問題Rei = i;
                }
                var j = model.問題VNIRei;
                if (j != null)
                {
                    j = j.Replace("＜", "<ruby>");
                    j = j.Replace("＞", "</ruby>");
                    j = j.Replace("｛", "<rt>");
                    j = j.Replace("｝", "</rt>");
                    model.問題VNIRei = j;
                }
                else
                {
                    model.問題VNIRei = j;
                }

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
                var model = db.問題.Find(Id);
                db.問題.Remove(model);
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