using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class GrammarController : EFModelController
    {
        //
        // GET: /Admin/Grammar/
        public ActionResult Index()
        {
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", selectedValue: true);

            return View();
        }

        public ActionResult Get(int? 第課ID)
        {
            var model = db.GrammarNihongoes.Where(p => p.第課ID == 第課ID).ToList();
            return PartialView("_List", model);
        }

        public ActionResult Edit(int Id)
        {
            var model = db.GrammarNihongoes.Find(Id);
            ViewBag.第課List = new SelectList(db.第課_Table, "第課ID", "第課Name", model.第課ID);
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(GrammarNihongo model)
        {
            try
            {
                var a = model.Grammar;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.Grammar = a;
                db.GrammarNihongoes.Add(model);
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
        public ActionResult Update(GrammarNihongo model)
        {
            try
            {
                var a = model.Grammar;

                a = a.Replace("＜", "<ruby>");
                a = a.Replace("＞", "</ruby>");
                a = a.Replace("｛", "<rt>");
                a = a.Replace("｝", "</rt>");
                model.Grammar = a;
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
                var model = db.GrammarNihongoes.Find(Id);
                db.GrammarNihongoes.Remove(model);
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