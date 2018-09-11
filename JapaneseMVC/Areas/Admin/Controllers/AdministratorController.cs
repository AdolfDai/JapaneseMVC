using JapaneseMVC.Common;
using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    [AdminAuthenticate]
    public class AdministratorController : EFModelController
    {
        //
        // GET: /Admin/Administrator/
        //
        public ActionResult Index()
        {
            ViewBag.Items = db.Administrators.ToList();
            return View();
        }

        public ActionResult Rule()
        {
            return View();
        }

        public ActionResult Edit(String Id)
        {
            var model = db.Administrators.Find(Id);
            ViewBag.Items = db.Administrators.ToList();
            return View("Index", model);
        }
        
        public ActionResult Insert(Administrator administrator)
        {
            try
            {
                administrator.DateCreated = DateTime.Now;
                administrator.DateModified = DateTime.Now;
                db.Administrators.Add(administrator);
                db.SaveChanges();
                ModelState.AddModelError("", "Inserted successful!");
                ModelState.Clear();
            }
            catch
            {
                ModelState.AddModelError("", "Inserting Failed!");
                ModelState.Clear();
            }
            return View("Index");
        }
       
        public ActionResult Update(Administrator administrator)
        {
            try
            {
                administrator.DateModified = DateTime.Now;
                db.Entry(administrator).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                ModelState.AddModelError("", "Updated Failed!");
                ModelState.Clear();
            }
            catch
            {
                ModelState.AddModelError("", "Updating Failed!");
                ModelState.Clear();
            }
            return View("Index");
        }
    }
}