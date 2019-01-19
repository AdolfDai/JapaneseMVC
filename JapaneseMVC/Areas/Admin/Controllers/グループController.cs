using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class グループController : EFModelController
    {
        //
        // GET: /Admin/グループ/
        public ActionResult Index()
        {
            ViewBag.Items = db.グループ.ToList();
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = db.グループ.Find(Id);
            ViewBag.Items = db.グループ.ToList();
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(グループ model)
        {
            try
            {
                db.グループ.Add(model);
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Inserted successful.");
            }
            catch
            {
                ModelState.AddModelError("", "Inserting failed.");
            }
            ViewBag.Items = db.グループ.ToList();
            return View("Index");
        }

        [ValidateInput(false)]
        public ActionResult Update(グループ model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Updated successful!");
            }
            catch
            {
                ModelState.AddModelError("", "Updating failed!");
            }

            ViewBag.Items = db.グループ.ToList();
            return View("Index");
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.グループ.Find(Id);
                db.グループ.Remove(model);
                db.SaveChanges();

                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.Items = db.グループ.ToList();
            return View("Index");
        }
    }
}