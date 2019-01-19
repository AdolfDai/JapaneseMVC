using System.Web.Mvc;
using System.Web.Routing;

namespace JapaneseMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Home",
                url: "Home/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "JapaneseMVC.Controllers" }
            );
            routes.MapRoute(
              name: "N5",
              url: "N5/{action}/{第課}",
              defaults: new { controller = "JpIndex", action = "Index", 第課 = UrlParameter.Optional },
              namespaces: new[] { "JapaneseMVC.Controllers" }
            );
            routes.MapRoute(
             name: "漢字",
             url: "漢字/{action}/{id}",
             defaults: new { controller = "漢字", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "JapaneseMVC.Controllers" }
            );
            routes.MapRoute(
             name: "動詞",
             url: "動詞/{action}/{id}",
             defaults: new { controller = "動詞", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "JapaneseMVC.Controllers" }
            );

        }
    }
}