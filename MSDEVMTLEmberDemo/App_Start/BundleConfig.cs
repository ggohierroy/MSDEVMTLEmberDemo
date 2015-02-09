using System.Web;
using System.Web.Optimization;

namespace MSDEVMTLEmberDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                        "~/BlogApp/dist/assets/vendor.js"));

            bundles.Add(new ScriptBundle("~/bundles/blog-app").Include(
                        "~/BlogApp/dist/assets/blog-app.js"));

            bundles.Add(new StyleBundle("~/content/vendor").Include(
                    "~/BlogApp/dist/assets/vendor.css"));

            bundles.Add(new StyleBundle("~/content/blog-app").Include(
                    "~/BlogApp/dist/assets/blog-app.css"));
        }
    }
}
