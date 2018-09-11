using System.Web.Optimization;

namespace JapaneseMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Core/js").Include(
                        "~/Assets/Admin/layout/vendor/jquery/jquery.js"
                        , "~/Assets/Admin/layout/vendor/bootstrap/js/bootstrap.js"
                         ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Core/modernizr").Include(
                            "~/Assets/Scripts/modernizr-2.6.2.js",
                            "~/Assets/Scripts/respond.js"
                        ));

            bundles.Add(new StyleBundle("~/Core/css").Include(
                     //bootstrap
                     "~/Assets/Admin/layout/vendor/bootstrap/css/bootstrap.css",
                     //admin page
                     "~/Assets/Admin/layout/dist/css/sb-admin-2.css",
                    "~/Assets/Admin/layout/vendor/metisMenu/metisMenu.css",
                     //font-awesome
                     "~/Assets/Admin/layout/vendor/font-awesome-4.7.0/css/font-awesome.css",
                     //Css dataTable
                     "~/Assets/Admin/layout/vendor/datatables/dataTables.bootstrap.css",
                     "~/Assets/Admin/layout/vendor/datatables-plugins/dataTables.bootstrap.css",
                     "~/Assets/Admin/layout/vendor/datatables-responsive/dataTables.responsive.css",
                     //Css jQuery UI
                     "~/Assets/lib/jquery-ui-1.11.4.custom/jquery-ui.css",
                     "~/Assets/lib/jquery-ui-1.11.4.custom/jquery-ui.theme.min.css",
                     //Css plug-in
                     "~/Assets/lib/video-js/video-js.css",
                     "~/Assets/lib/Hover-master/css/hover.css",
                     "~/Assets/calendar/calendar.css",
                     //css scrollDiv
                     "~/Assets/scrollDiv/cssScrollDivBtn.css"
                     ));

            bundles.Add(new ScriptBundle("~/Core/jquery").Include(
                      //admin page
                      "~/Assets/Admin/layout/dist/js/sb-admin-2.js",
                      "~/Assets/Admin/layout/vendor/metisMenu/metisMenu.js",
                     //js jQuery UI
                     "~/Assets/lib/jquery-ui-1.11.4.custom/jquery-ui.js",
                      //js dataTable
                      "~/Assets/Admin/layout/vendor/datatables/js/jquery.dataTables.min.js",
                      "~/Assets/Admin/layout/vendor/datatables-plugins/dataTables.bootstrap.min.js",
                      "~/Assets/Admin/layout/vendor/datatables-responsive/dataTables.responsive.js",
                      //video
                      "~/Assets/lib/video-js/video.js",
                      //js scrollDiv
                      "~/Assets/scrollDiv/jsScrollDivBtn.js"
                     ));

            //Client
            bundles.Add(new StyleBundle("~/Client/css").Include(
                "~/Assets/Client/MinnanoNihongoPage/ClientCss.css",
                "~/Assets/Client/HomePage/bgClient.css",
                "~/Assets/Client/HomePage/FooterCss.css"
                ));

            bundles.Add(new ScriptBundle("~/Client/js").Include(
                "~/Assets/Client/MinnanoNihongoPage/jsList.js"
                 ));

            //Admin
            bundles.Add(new StyleBundle("~/Admin/css").Include(
                "~/Assets/Admin/css/cssLoginLayout.css",
                "~/Assets/Admin/css/AdminCss.css"
                ));

            bundles.Add(new ScriptBundle("~/Admin/js").Include(
                      //js plug-in
                      "~/Assets/plug-in/ckeditor/ckfinder.js",
                      "~/Assets/plug-in/ckeditor/ckeditor.js"
                 ));

            BundleTable.EnableOptimizations = false;
        }
    }
}