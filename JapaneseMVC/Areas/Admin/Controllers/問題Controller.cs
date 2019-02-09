using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
	[AdminAuthenticate]
	public class 問題Controller : EFModelController
	{
		#region 問題
		//
		// GET: /Admin/問題/
		//
		[HttpGet]
		public ActionResult Index()
		{
			ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);
			return View();
		}

		[HttpGet]
		public ActionResult Get(int? 第課ID)
		{
			var model = db.問題.Where(p => p.第課ID == 第課ID).ToList();
			return PartialView("_List問題", model);
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
			var fileImage = Request.Files["Up問題Image"];
			if (fileImage.ContentLength > 0)
			{
				model.問題の写真 = fileImage.FileName;
				var path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
				fileImage.SaveAs(path問題Img);
			}
			else
			{
				model.問題の写真 = "noimage.jpg";
			}

			var fileAudio = Request.Files["Up問題Audio"];
			if (fileAudio.ContentLength > 0)
			{
				model.問題Audio = fileAudio.FileName;
				var path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
				fileAudio.SaveAs(path問題Audio);
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
			var fileImage = Request.Files["Up問題Image"];
			if (fileImage.ContentLength > 0)
			{
				var path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
				if (System.IO.File.Exists(path問題Img))
				{
					System.IO.File.Delete(path問題Img);
					model.問題の写真 = fileImage.FileName;
					path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
					fileImage.SaveAs(path問題Img);
				}
				else
				{
					model.問題の写真 = fileImage.FileName;
					path問題Img = Server.MapPath("~/img/問題Img/" + model.問題の写真);
					fileImage.SaveAs(path問題Img);
				}
			}

			var fileAudio = Request.Files["Up問題Audio"];
			if (fileAudio.ContentLength > 0)
			{
				var path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
				if (System.IO.File.Exists(path問題Audio))
				{
					System.IO.File.Delete(path問題Audio);
					model.問題Audio = fileAudio.FileName;
					path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
					fileAudio.SaveAs(path問題Audio);
				}
				else
				{
					model.問題Audio = fileAudio.FileName;
					path問題Audio = Server.MapPath("~/audio/問題/" + model.問題Audio);
					fileAudio.SaveAs(path問題Audio);
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
		#endregion
	}
}