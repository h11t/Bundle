using System;
using System.Web.Optimization;

namespace Bundle_Islemleri.App_Start
{
    public class BundleConfig
    {
        internal static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/modernizr-2.6.2.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Site.css"
                ));
            BundleTable.EnableOptimizations = true;
        }
    }
}