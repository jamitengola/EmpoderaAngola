using System.Web;
using System.Web.Optimization;

namespace Empodera
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/js/jquery-2.2.4.min.js",
                      "~/js/bootstrap.min.js",
                      "~/js/owl.carousel.min.js",
                      "~/js/jquery.scrollUp.min.js",
                      "~/js/jquery.counterup.min.js",
                      "~/js/modernizr.min.js",
                      "~/js/waypoints.min.js",
                      "~/js/jquery.meanmenu.min.js",
                      "~/js/bootstrap-4-hover-navbar.js",
                      "~/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animated.css",
                      "~/Content/bootstrap-4-hover-navbar.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/main.css",
                      "~/Content/meanmenu.min.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/responsive.css"));
        }
    }
}
