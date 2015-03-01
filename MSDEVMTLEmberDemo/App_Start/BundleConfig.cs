using System.Web;
using System.Web.Optimization;

namespace MSDEVMTLEmberDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/ember").Include(
                        "~/Scripts/ember-template-compiler.js",
                        "~/Scripts/ember-1.10.0.debug.js"));

            bundles.Add(new ScriptBundle("~/bundles/emberApp").Include(
                        "~/Scripts/app.js",
                        "~/Scripts/Models/*.js",
                        "~/Scripts/Routes/*.js",
                        "~/Scripts/Controllers/*.js",
                        "~/Scripts/data.js"));
        }
    }
}
