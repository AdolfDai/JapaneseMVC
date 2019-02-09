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
	public class 問題の答えController : EFModelController
	{
		#region 問題の答え
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Get(int? 問題ID)
		{
			var model = GetById(問題ID);
			return PartialView("_List問題の答え", model);
		}

		public ActionResult Edit(int 問題の答えId)
		{
			var model = db.問題の答えTable.Find(問題の答えId);
			return View("Index", model);
		}

		[ValidateInput(false)]
		public ActionResult Insert(問題の答えTable model)
		{
			try
			{
				var a = model.問題の答え;
				a = a.Replace("＜", "<ruby>");
				a = a.Replace("＞", "</ruby>");
				a = a.Replace("｛", "<rt>");
				a = a.Replace("｝", "</rt>");
				model.問題の答え = a;
				db.問題の答えTable.Add(model);
				db.SaveChanges();
				ModelState.Clear();
				ModelState.AddModelError("", "Thêm thành công!");
			}
			catch
			{
				ModelState.AddModelError("", "Thêm thất bại!");
			}
			return View("Index");
		}

		[ValidateInput(false)]
		public ActionResult Update(問題の答えTable model)
		{
			try
			{
				var a = model.問題の答え;
				a = a.Replace("＜", "<ruby>");
				a = a.Replace("＞", "</ruby>");
				a = a.Replace("｛", "<rt>");
				a = a.Replace("｝", "</rt>");
				model.問題の答え = a;

				db.Entry(model).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				ModelState.Clear();
				ModelState.AddModelError("", "Update thành công!");
			}
			catch
			{
				ModelState.AddModelError("", "Update thất bại!");
			}
			return View("Index");
		}

		public ActionResult Delete問題の答え(int 問題の答えId)
		{
			try
			{
				var model = db.問題の答えTable.Find(問題の答えId);
				db.問題の答えTable.Remove(model);
				db.SaveChanges();
				ModelState.Clear();
				ModelState.AddModelError("", "Deleted successfull!");
			}
			catch
			{
				ModelState.AddModelError("", "Deleting Failed!");
			}
			return View("Index");
		}
		#endregion

		public List<問題の答えTable> GetById(int? 問題ID)
		{
			return db.問題の答えTable.Where(x => x.問題Id == 問題ID).ToList();
		}
	}
}
