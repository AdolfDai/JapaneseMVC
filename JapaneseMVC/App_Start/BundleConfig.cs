using System.Web.Optimization;

namespace JapaneseMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Core/js").Include(
                        "~/Assets/vendor/jquery/jquery.js"
                        , "~/Assets/vendor/bootstrap/js/bootstrap.js"
                         ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Core/modernizr").Include(
                            "~/Assets/Scripts/modernizr-2.6.2.js",
                            "~/Assets/Scripts/respond.js"
                        ));

            bundles.Add(new StyleBundle("~/Core/css").Include(
                     //bootstrap
                     "~/Assets/vendor/bootstrap/css/bootstrap.css",
                     //admin page
                     "~/Assets/dist/css/sb-admin-2.css",
                    "~/Assets/vendor/metisMenu/metisMenu.css",
                     //font-awesome
                     "~/Assets/vendor/font-awesome-4.7.0/css/font-awesome.css",
                     //Css dataTable
                     "~/Assets/vendor/datatables/dataTables.bootstrap.css",
                     "~/Assets/vendor/datatables-plugins/dataTables.bootstrap.css",
                     "~/Assets/vendor/datatables-responsive/dataTables.responsive.css",
                     //Css jQuery UI
                     "~/Assets/jquery-ui-1.11.4.custom/jquery-ui.css",
                     "~/Assets/jquery-ui-1.11.4.custom/jquery-ui.theme.min.css",
                     //Css plug-in
                     "~/Assets/video-js/video-js.css",
                     "~/Assets/Hover-master/css/hover.css",
                     "~/Assets/calendar/calendar.css",
                     //css scrollDiv
                     "~/Assets/scrollDiv/cssScrollDivBtn.css"
                     ));

            bundles.Add(new ScriptBundle("~/Core/jquery").Include(

                      //admin page
                      "~/Assets/dist/js/sb-admin-2.js",
                      "~/Assets/vendor/metisMenu/metisMenu.js",
                     //js jQuery UI
                     "~/Assets/jquery-ui-1.11.4.custom/jquery-ui.js",
                      //js angularjs
                      "~/Assets/AngularJS/angular.min.js",
                      //js dataTable
                      "~/Assets/vendor/datatables/js/jquery.dataTables.min.js",
                      "~/Assets/vendor/datatables-plugins/dataTables.bootstrap.min.js",
                      "~/Assets/vendor/datatables-responsive/dataTables.responsive.js",

                      //video
                      "~/Assets/video-js/video.js",
                      //calendar
                      "~/Assets/calendar/calendar.js",
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