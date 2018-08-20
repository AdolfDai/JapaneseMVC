using JapaneseMVC.Common;
using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    public class AdministratorController : EFModelController
    {
        //
        // GET: /Admin/Administrator/
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

        public ActionResult Login()
        {
            var cookie = Request.Cookies["Administrator"];
            //cookie.Secure = true;
            if (cookie != null)
            {
                ViewBag.Id = cookie.Values["Id"];
                ViewBag.Paswword = cookie.Values["Password"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(String Id, String Password, Boolean Remember)
        {
            var admin = db.Administrators.Find(Id);
            if (ModelState.IsValid)
            {
                if (admin == null)
                {
                    ModelState.AddModelError("", "Administrator does not exits.");
                }
                else if (admin.Status == false)
                {
                    ModelState.AddModelError("", "Administrator has not actived yet.");
                }
                else if (admin.Password != EncryptorMD5.MD5Hash(Password))
                {
                    ModelState.AddModelError("", "Username or Password is not correct.");
                }
                else
                {
                    ModelState.AddModelError("", "Login Successed.");
                    //add session
                    Session["Administrator"] = admin;

                    //Luu cookie
                    var cookie = new HttpCookie("Administrator");
                    if (Remember)
                    {
                        cookie.Values["userName"] = Id;
                        cookie.Values["Password"] = EncryptorMD5.MD5Hash(Password);
                        cookie.Expires = DateTime.Now.AddDays(5);
                    }
                    else
                    {
                        cookie.Expires = DateTime.Now;
                    }
                    Response.Cookies.Add(cookie);
                }

                //
                var url = Session["RequestUrl"];
                if (url != null)
                {
                    return Redirect(url.ToString());
                }
                else if (admin != null)
                {
                    return RedirectToAction("Index", "DaiKa");
                }
            }
            return View();
        }

        [AdminAuthenticate]
        public ActionResult Logoff()
        {
            Session.Remove("Administrator");
            return RedirectToAction("Login", "Administrator");
        }
    }
}