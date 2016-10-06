using System.Web;
using System.Web.Optimization;

namespace Trestto.Dashboard.App
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(

                               "~/dashboard/modules/common.module.js",
                           "~/dashboard/app.js",
                           "~/dashboard/services/apiSevice.js",
                      "~/dashboard/home/home.controller.js",
                                        "~/dashboard/home/rootCtrl.js"
           ));
            
            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                 "~/Scripts/Angular/angular.min.js",
                 "~/Scripts/Angular/ngRoute.js",
                 "~/Scripts/Angular/ui-bootstrap.min.js",
                 "~/Scripts/Angular/angular-perfect-scrollbar.js",
                 "~/Scripts/Angular/calendar.js",
                 "~/Scripts/Angular/loading-bar.js", 
                 "~/Scripts/Angular/slider.js",
                 "~/Scripts/Angular/angular-notify.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     
                      "~/Content/bootstrap.css",

                      "~/Content/site.css"));
        }
    }
}
