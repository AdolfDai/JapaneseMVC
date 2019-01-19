using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using JapaneseMVC.Common;
using JapaneseMVC.Controllers;
using JapaneseMVC.FilerUrl;

namespace JapaneseMVC.Areas.Admin.Controllers
{
    public class LoginController : EFModelController
    {
        //
        // GET: Admin/Login
        //
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdmLogin()
        {
            //string url = Session["RequestUrl"].ToString();
            //url = "/Admin/Login/AdmLogin";
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
        public ActionResult AdmLogin(String Id, String Password, Boolean Remember)
        {
            var admin = db.Administrators.Find(Id);
            //if (ModelState.IsValid)
            //{
            if (admin == null)
            {
                ModelState.AddModelError("", "Administrator does not exits.");
            }
            else if (admin.Status != true)
            {
                ModelState.AddModelError("", "Administrator has not actived yet.");
            }
            else if (admin.Password != EncryptorMD5.MD5Hash(Password))
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Username or Password is not correct.");

            }
            else
            {
                ModelState.AddModelError("", "Login Successed.");
                //add session
                Session["Administrator"] = admin;

                //request url
                var url = Session["RequestUrl"] as String;
                if (url != null)
                {
                    return Redirect(url);
                }
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
            //}
            return View();
        }

        [AdminAuthenticate]
        public ActionResult Logoff()
        {
            Session.Remove("Administrator");
            return RedirectToAction("Login", "Login");
        }
    }
}