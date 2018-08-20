using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class DaiKaController : EFModelController
    {
        //
        // GET: /Admin/DaiKa/
        public ActionResult Index()
        {
            ViewBag.Items = db.第課_Table.ToList();
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = db.第課_Table.Find(Id);
            ViewBag.Items = db.第課_Table.ToList();
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(第課_Table model)
        {
            var f言葉 = Request.Files["Up言葉"];
            if (f言葉.ContentLength > 0)
            {
                model.言葉audio = f言葉.FileName;
                var path言葉 = Server.MapPath("~/audio/言葉/" + model.言葉audio);
                f言葉.SaveAs(path言葉);
            }
            else
            {
                model.言葉audio = "MadeInAbyss.mp3";
            }

            var f文型 = Request.Files["Up文型"];
            if (f文型.ContentLength > 0)
            {
                model.文型audio = f文型.FileName;
                var path文型 = Server.MapPath("~/audio/文型/" + model.文型audio);
                f文型.SaveAs(path文型);
            }
            else
            {
                model.文型audio = "MadeInAbyss.mp3";
            }

            var f例文 = Request.Files["Up例文"];
            if (f例文.ContentLength > 0)
            {
                model.例文audio = f例文.FileName;
                var path例文 = Server.MapPath("~/audio/例文/" + model.例文audio);
                f例文.SaveAs(path例文);
            }
            else
            {
                model.例文audio = "MadeInAbyss.mp3";
            }
            try
            {
                var b = model.第課Subject;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.第課Subject = b;
                db.第課_Table.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Thêm thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Thêm thất bại!");
            }
            ViewBag.Items = db.第課_Table.ToList();
            return View("Index");
        }

        [ValidateInput(false)]
        public ActionResult Update(第課_Table model)
        {
            var f言葉 = Request.Files["Up言葉"];
            if (f言葉.ContentLength > 0)
            {
                var path言葉 = Server.MapPath("~/audio/言葉/" + model.言葉audio);
                if (System.IO.File.Exists(path言葉))
                {
                    System.IO.File.Delete(path言葉);
                    model.言葉audio = f言葉.FileName;
                    path言葉 = Server.MapPath("~/audio/言葉/" + model.言葉audio);
                    f言葉.SaveAs(path言葉);
                }
                else
                {
                    model.言葉audio = f言葉.FileName;
                    path言葉 = Server.MapPath("~/audio/言葉/" + model.言葉audio);
                    f言葉.SaveAs(path言葉);
                }
            }

            var f文型 = Request.Files["Up文型"];
            if (f文型.ContentLength > 0)
            {
                var path文型 = Server.MapPath("~/audio/文型/" + model.文型audio);
                if (System.IO.File.Exists(path文型))
                {
                    System.IO.File.Delete(path文型);
                    model.文型audio = f文型.FileName;
                    path文型 = Server.MapPath("~/audio/文型/" + model.文型audio);
                    f文型.SaveAs(path文型);
                }
                else
                {
                    model.文型audio = f文型.FileName;
                    path文型 = Server.MapPath("~/audio/文型/" + model.文型audio);
                    f文型.SaveAs(path文型);
                }
            }

            var f例文 = Request.Files["Up例文"];
            if (f例文.ContentLength > 0)
            {
                var path例文 = Server.MapPath("~/audio/例文/" + model.例文audio);
                if (System.IO.File.Exists(path例文))
                {
                    System.IO.File.Delete(path例文);
                    model.例文audio = f例文.FileName;
                    path例文 = Server.MapPath("~/audio/例文/" + model.例文audio);
                    f例文.SaveAs(path例文);
                }
                else
                {
                    model.例文audio = f例文.FileName;
                    path例文 = Server.MapPath("~/audio/例文/" + model.例文audio);
                    f例文.SaveAs(path例文);
                }
            }

            try
            {
                var b = model.第課Subject;

                b = b.Replace("＜", "<ruby>");
                b = b.Replace("＞", "</ruby>");
                b = b.Replace("｛", "<rt>");
                b = b.Replace("｝", "</rt>");

                model.第課Subject = b;

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Update thành công!");
            }
            catch
            {
                ModelState.AddModelError("", "Update thất bại!");
            }

            ViewBag.Items = db.第課_Table.ToList();
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.第課_Table.Find(Id);
                db.第課_Table.Remove(model);
                db.SaveChanges();

                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.Items = db.第課_Table.ToList();
            return View("Index");
        }
    }
}