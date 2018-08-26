using JapaneseMVC.Controllers;
using Model.EF;
using System.Linq;
using System.Web.Mvc;
using JapaneseMVC.FilerUrl;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class かなとはくController : EFModelController
    {
        //
        // GET: /Admin/かなとはく/
        public ActionResult Index()
        {
            ViewBag.Items = db.かなとはく.ToList();
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = db.かなとはく.Find(Id);
            ViewBag.Items = db.かなとはく.ToList();
            return View("Index", model);
        }

        public ActionResult Insert(かなとはく model)
        {
            var f = Request.Files["UpImageHiragana"];
            if (f.ContentLength > 0)
            {
                model.ImageHiragana = f.FileName;
                var pathImageHiragana = Server.MapPath("~/img/かなとはく/hiragana/" + f.FileName);
                f.SaveAs(pathImageHiragana);
            }
            else
            {
                model.ImageHiragana = "No Image File";
            }
            var f1 = Request.Files["UpImageKatakana"];
            if (f1.ContentLength > 0)
            {
                model.ImageKatakana = f1.FileName;
                var pathImageKatakana = Server.MapPath("~/img/かなとはく/katakana/" + f1.FileName);
                f.SaveAs(pathImageKatakana);
            }
            else
            {
                model.ImageKatakana = "No Image File";
            }
            try
            {
                db.かなとはく.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Thêm mới thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Thêm mới thất bại!");
            }
            ViewBag.Items = db.かなとはく.ToList();
            return View("Index");
        }

        public ActionResult Update(かなとはく model)
        {
            var f = Request.Files["UpImageHiragana"];
            if (f.ContentLength > 0)
            {
                var pathImageHiragana = Server.MapPath("~/img/かなとはく/hiragana/" + model.ImageHiragana);
                if (System.IO.File.Exists(pathImageHiragana))
                {
                    System.IO.File.Delete(pathImageHiragana);
                    model.ImageHiragana = f.FileName;
                    pathImageHiragana = Server.MapPath("~/img/かなとはく/hiragana/" + f.FileName);
                    f.SaveAs(pathImageHiragana);
                }
                else
                {
                    model.ImageHiragana = f.FileName;
                    pathImageHiragana = Server.MapPath("~/img/かなとはく/hiragana/" + f.FileName);
                    f.SaveAs(pathImageHiragana);
                }
            }

            var f1 = Request.Files["UpImageKatakana"];
            if (f1.ContentLength > 0)
            {
                var pathImageKatakana = Server.MapPath("~/img/かなとはく/katakana/" + model.ImageKatakana);
                if (System.IO.File.Exists(pathImageKatakana))
                {
                    System.IO.File.Delete(pathImageKatakana);
                    model.ImageKatakana = f1.FileName;
                    pathImageKatakana = Server.MapPath("~/img/かなとはく/katakana/" + f1.FileName);
                    f1.SaveAs(pathImageKatakana);
                }
                else
                {
                    model.ImageKatakana = f1.FileName;
                    pathImageKatakana = Server.MapPath("~/img/かなとはく/katakana/" + f1.FileName);
                    f1.SaveAs(pathImageKatakana);
                }
            }
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
            ViewBag.Items = db.かなとはく.ToList();
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.かなとはく.Find(Id);
                db.かなとはく.Remove(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.Items = db.かなとはく.ToList();
            return View("Index");
        }
    }
}