using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
	[AdminAuthenticate]
	public class 練習CController : EFModelController
	{
		//
		// GET: /Admin/練習C/
		public ActionResult Index()
		{
			ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", selectedValue: true);

			return View();
		}

		public ActionResult Get(int? 第課ID)
		{
			var model = db.練習C.Where(p => p.第課ID == 第課ID).ToList();
			return PartialView("_List", model);
		}

		public ActionResult Edit(int Id)
		{
			var model = db.練習C.Find(Id);
			ViewBag.第課List = new SelectList(db.第課, "第課ID", "第課の名", model.第課ID);

			return View("Index", model);
		}

		[ValidateInput(false)]
		public ActionResult Insert(練習C model)
		{
			var file = Request.Files["Up練習CAudio"];
			if (file.ContentLength > 0)
			{
				model.練習CAudio = file.FileName;
				var path練習C = Server.MapPath("~/audio/練習/" + model.練習CAudio);
				file.SaveAs(path練習C);
			}
			else
			{
				model.練習CAudio = "No File Audio";
			}
			var file1 = Request.Files["Up練習CImg"];
			if (file1.ContentLength > 0)
			{
				model.練習Cの写真 = file1.FileName;
				var path練習CImg = Server.MapPath("~/img/練習CImg/" + model.練習Cの写真);
				file1.SaveAs(path練習CImg);
			}
			else
			{
				model.練習Cの写真 = "noimage.jpg";
			}
			try
			{
				var a = model.練習Cの本;
				a = a.Replace("＜", "<ruby>");
				a = a.Replace("＞", "</ruby>");
				a = a.Replace("｛", "<rt>");
				a = a.Replace("｝", "</rt>");
				model.練習Cの本 = a;

				var b = model.ベトナム語;
				b = b.Replace("＜", "<ruby>");
				b = b.Replace("＞", "</ruby>");
				b = b.Replace("｛", "<rt>");
				b = b.Replace("｝", "</rt>");
				model.ベトナム語 = b;

				var c = model.練習C1Ans;
				c = c.Replace("＜", "<ruby>");
				c = c.Replace("＞", "</ruby>");
				c = c.Replace("｛", "<rt>");
				c = c.Replace("｝", "</rt>");
				model.練習C1Ans = c;

				var d = model.練習C1AnsVNI;
				d = d.Replace("＜", "<ruby>");
				d = d.Replace("＞", "</ruby>");
				d = d.Replace("｛", "<rt>");
				d = d.Replace("｝", "</rt>");
				model.練習C1AnsVNI = d;

				var e = model.練習C2Ans;
				e = e.Replace("＜", "<ruby>");
				e = e.Replace("＞", "</ruby>");
				e = e.Replace("｛", "<rt>");
				e = e.Replace("｝", "</rt>");
				model.練習C2Ans = e;

				var f = model.練習C2AnsVNI;
				f = f.Replace("＜", "<ruby>");
				f = f.Replace("＞", "</ruby>");
				f = f.Replace("｛", "<rt>");
				f = f.Replace("｝", "</rt>");
				model.練習C2AnsVNI = f;

				//check null
				var g = model.練習C3Ans;
				if (g != null)
				{
					g = g.Replace("＜", "<ruby>");
					g = g.Replace("＞", "</ruby>");
					g = g.Replace("｛", "<rt>");
					g = g.Replace("｝", "</rt>");
					model.練習C3Ans = g;
				}
				else
				{
					model.練習C3Ans = g;
				}

				var h = model.練習C3AnsVNI;
				if (h != null)
				{
					h = h.Replace("＜", "<ruby>");
					h = h.Replace("＞", "</ruby>");
					h = h.Replace("｛", "<rt>");
					h = h.Replace("｝", "</rt>");
					model.練習C3AnsVNI = h;
				}
				else
				{
					model.練習C3AnsVNI = h;
				}
				
				db.練習C.Add(model);
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
		public ActionResult Update(練習C model)
		{
			var file = Request.Files["Up練習CAudio"];
			if (file.ContentLength > 0)
			{
				var path練習C = Server.MapPath("~/audio/練習/" + model.練習CAudio);
				if (System.IO.File.Exists(path練習C))
				{
					System.IO.File.Delete(path練習C);
					model.練習CAudio = file.FileName;
					path練習C = Server.MapPath("~/audio/練習/" + model.練習CAudio);
					file.SaveAs(path練習C);
				}
				else
				{
					model.練習CAudio = file.FileName;
					path練習C = Server.MapPath("~/audio/練習/" + model.練習CAudio);
					file.SaveAs(path練習C);
				}
			}

			var file1 = Request.Files["Up練習CImg"];
			if (file1.ContentLength > 0)
			{
				var path練習CImg = Server.MapPath("~/img/練習CImg/" + model.練習Cの写真);
				if (System.IO.File.Exists(path練習CImg))
				{
					System.IO.File.Delete(path練習CImg);
					model.練習Cの写真 = file1.FileName;
					path練習CImg = Server.MapPath("~/img/練習CImg/" + model.練習Cの写真);
					file1.SaveAs(path練習CImg);
				}
				else
				{
					model.練習Cの写真 = file1.FileName;
					path練習CImg = Server.MapPath("~/img/練習CImg/" + model.練習Cの写真);
					file1.SaveAs(path練習CImg);
				}
			}

			try
			{
				var a = model.練習Cの本;
				a = a.Replace("＜", "<ruby>");
				a = a.Replace("＞", "</ruby>");
				a = a.Replace("｛", "<rt>");
				a = a.Replace("｝", "</rt>");
				model.練習Cの本 = a;

				var b = model.ベトナム語;
				b = b.Replace("＜", "<ruby>");
				b = b.Replace("＞", "</ruby>");
				b = b.Replace("｛", "<rt>");
				b = b.Replace("｝", "</rt>");
				model.ベトナム語 = b;

				var c = model.練習C1Ans;
				c = c.Replace("＜", "<ruby>");
				c = c.Replace("＞", "</ruby>");
				c = c.Replace("｛", "<rt>");
				c = c.Replace("｝", "</rt>");
				model.練習C1Ans = c;

				var d = model.練習C1AnsVNI;
				d = d.Replace("＜", "<ruby>");
				d = d.Replace("＞", "</ruby>");
				d = d.Replace("｛", "<rt>");
				d = d.Replace("｝", "</rt>");
				model.練習C1AnsVNI = d;

				var e = model.練習C2Ans;
				e = e.Replace("＜", "<ruby>");
				e = e.Replace("＞", "</ruby>");
				e = e.Replace("｛", "<rt>");
				e = e.Replace("｝", "</rt>");
				model.練習C2Ans = e;

				var f = model.練習C2AnsVNI;
				f = f.Replace("＜", "<ruby>");
				f = f.Replace("＞", "</ruby>");
				f = f.Replace("｛", "<rt>");
				f = f.Replace("｝", "</rt>");
				model.練習C2AnsVNI = f;

				//check null
				var g = model.練習C3Ans;
				if (g != null)
				{
					g = g.Replace("＜", "<ruby>");
					g = g.Replace("＞", "</ruby>");
					g = g.Replace("｛", "<rt>");
					g = g.Replace("｝", "</rt>");
					model.練習C3Ans = g;
				}
				else
				{
					model.練習C3Ans = g;
				}

				var h = model.練習C3AnsVNI;
				if (h != null)
				{
					h = h.Replace("＜", "<ruby>");
					h = h.Replace("＞", "</ruby>");
					h = h.Replace("｛", "<rt>");
					h = h.Replace("｝", "</rt>");
					model.練習C3AnsVNI = h;
				}
				else
				{
					model.練習C3AnsVNI = h;
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
				var model = db.練習C.Find(Id);
				db.練習C.Remove(model);
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