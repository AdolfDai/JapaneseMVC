using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace JapaneseMVC.FilerUrl
{
    public class Authenticate : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = HttpContext.Current.Session["User"] as User;
            if (user == null)
            {
                //Luu lai url de khi dang nhap xong se quay lai
                var url = HttpContext.Current.Request.Url.AbsoluteUri;
                HttpContext.Current.Session["RequestUrl"] = url;
                HttpContext.Current.Response.Redirect("/User/Login");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}