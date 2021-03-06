﻿using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class 会話Controller : EFModelController
    {
        //
        // GET: /Admin/会話/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", selectedValue: true);
            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.会話_Table.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.会話_Table.Find(Id);
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(会話_Table model)
        {
            var f = Request.Files["Up会話Img"];
            if (f.ContentLength > 0)
            {
                model.会話Image = f.FileName;
                var path会話Img = Server.MapPath("~/img/会話/" + model.会話Image);
                f.SaveAs(path会話Img);
            }
            else
            {
                model.会話Image = "noimage.jpg";
            }
            var f会話Audio = Request.Files["Up会話Audio"];
            if (f会話Audio.ContentLength > 0)
            {
                model.会話Audio = f会話Audio.FileName;
                var path会話Audio = Server.MapPath("~/audio/会話/" + model.会話Audio);
                f会話Audio.SaveAs(path会話Audio);
            }
            else
            {
                model.会話Audio = "MadeInAbyss.mp3";
            }
            try
            {
                var a = model.会話;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.会話 = a;
                db.会話_Table.Add(model);
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
        public ActionResult Update(会話_Table model)
        {
            //Image
            var f = Request.Files["Up会話Img"];
            if (f.ContentLength > 0)
            {
                var path会話Img = Server.MapPath("~/img/会話/" + model.会話Image);
                if (System.IO.File.Exists(path会話Img))
                {
                    System.IO.File.Delete(path会話Img);
                    model.会話Image = f.FileName;
                    path会話Img = Server.MapPath("~/img/会話/" + model.会話Image); f.SaveAs(path会話Img);
                }
                else
                {
                    model.会話Image = f.FileName;
                    path会話Img = Server.MapPath("~/img/会話/" + model.会話Image); f.SaveAs(path会話Img);
                }
            }

            //Audio
            var f会話Audio = Request.Files["Up会話Audio"];
            if (f会話Audio.ContentLength > 0)
            {
                var path会話Audio = Server.MapPath("~/audio/会話/" + model.会話Audio);
                if (System.IO.File.Exists(path会話Audio))
                {
                    System.IO.File.Delete(path会話Audio);
                    model.会話Image = f会話Audio.FileName;
                    path会話Audio = Server.MapPath("~/audio/会話/" + model.会話Audio); f会話Audio.SaveAs(path会話Audio);
                }
                else
                {
                    model.会話Audio = f会話Audio.FileName;
                    path会話Audio = Server.MapPath("~/audio/会話/" + model.会話Audio); f会話Audio.SaveAs(path会話Audio);
                }
            }

            try
            {
                var a = model.会話;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.会話 = a;
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
                var model = db.会話_Table.Find(Id);
                db.会話_Table.Remove(model);
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