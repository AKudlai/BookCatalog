using System.Web.Optimization;

namespace BookCatalog.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap.min.css",
                         "~/Content/themes/base/jquery-ui.min.css"));

            bundles.Add(new StyleBundle("~/Content/chosen").Include(
                "~/Content/chosen.css"));

            bundles.Add(new StyleBundle("~/Content/css/DataTables").Include(
                "~/Content/DataTables/css/jquery.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/select2").Include(
                "~/Content/css/select2.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryUI")
               .Include("~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidate").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables")
                .Include("~/Scripts/DataTables/jquery.dataTables.min.js",
                         "~/Scripts/DataTables/dataTables.bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/select2")
                .Include("~/Scripts/select2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/appscripts")
                .Include("~/Scripts/AppScripts/BookCatalog.js",
                         "~/Sripts/AppScripts/Modal.js"));
        }
    }
}