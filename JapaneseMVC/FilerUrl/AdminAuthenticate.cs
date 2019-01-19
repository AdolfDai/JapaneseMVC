using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;
using System.Web.Mvc;

namespace JapaneseMVC.FilerUrl
{
    public class AdminAuthenticate : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var  master = HttpContext.Current.Session["Administrator"] as Administrator;

            if (master == null)
            {
                //Luu lai url de khi dang nhap xong se quay lai
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                HttpContext.Current.Session["RequestUrl"] = url;
                HttpContext.Current.Response.Redirect("/Admin/Login/AdmLogin");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}