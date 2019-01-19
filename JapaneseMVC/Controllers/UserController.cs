using JapaneseMVC.Common;
using JapaneseMVC.FilerUrl;
using System;
using System.Web;
using System.Web.Mvc;

namespace JapaneseMVC.Controllers
{
    public class UserController : EFModelController
    {
        //
        // GET: /User/
        public ActionResult UserLogin()
        {
            var cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                ViewBag.Id = cookie.Values["Id"];
                ViewBag.Paswword = cookie.Values["Password"];
            }
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(String Id, String Password, Boolean Remember)
        {
            var user = db.Users.Find(Id);
            if (ModelState.IsValid)
            {
                if (user == null)
                {
                    ModelState.AddModelError("", "User does not exits.");
                }
                else if (user.Status == false)
                {
                    ModelState.AddModelError("", "User has not actived yet.");
                }
                else if (user.Password != EncryptorMD5.MD5Hash(Password))
                {
                    ModelState.AddModelError("", "Username or Password is not correct.");
                }
                else
                {
                    ModelState.AddModelError("", "Login Successed.");
                    //add session
                    Session["User"] = user;

                    //Luu cookie
                    var cookie = new HttpCookie("User");
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
                else if (user != null)
                {
                    return RedirectToAction("ActorJpIndex", "JpIndex");
                }
            }
            return View();
        }

        [Authenticate]
        public ActionResult Logoff()
        {
            Session.Remove("User");
            return RedirectToAction("Index", "Home");
        }
    }
}