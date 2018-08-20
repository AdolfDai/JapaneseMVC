using JapaneseMVC.Controllers;
using Model.EF;
using System.Linq;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    public class Group動詞Controller : EFModelController
    {
        // GET: Admin/Group動詞
        public ActionResult Index()
        {
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var model = db.Group動詞.Find(Id);
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View("Index", model);
        }

        [ValidateInput(false)]
        public ActionResult Insert(Group動詞 group)
        {
            try
            {
                db.Group動詞.Add(group);
                db.SaveChanges();
                ModelState.AddModelError("", "Inserted successful.");
                ModelState.Clear();
            }
            catch
            {
                ModelState.AddModelError("", "Inserting failed.");
                ModelState.Clear();
            }

            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View();
        }

        [ValidateInput(false)]
        public ActionResult Update(Group動詞 group)
        {
            try
            {
                db.Entry(group).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.Clear();
                ModelState.AddModelError("", "Updated successful!");
            }
            catch
            {
                ModelState.AddModelError("", "Updating failed!");
            }
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View();
        }

        public ActionResult Delete(int Id)
        {
            try
            {
                var model = db.Group動詞.Find(Id);
                db.Group動詞.Remove(model);
                db.SaveChanges();

                ModelState.Clear();
                ModelState.AddModelError("", "Deleted successfull!");
            }
            catch
            {
                ModelState.AddModelError("", "Deleting Failed!");
            }
            ViewBag.Group動詞 = db.Group動詞.ToList();
            return View("Index");
        }
    }
}