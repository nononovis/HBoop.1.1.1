using System.Web;
using System.Web.Optimization;

namespace Zasta.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Ux/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/style").Include(
                      "~/Content/styles.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/styleClient").Include(
                      "~/Areas/Beneficiary/Styles/styles.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/styleAdmin").Include(
                      "~/Areas/Affiliate/Styles/style.css",
                      "~/Content/font-awesome.min.css",
                      "~/Areas/Affiliate/Styles/nanoscroller.css"));


            bundles.Add(new ScriptBundle("~/bundles/AdminConfirme")
            .Include("~/Areas/Affiliate/Scripts/confirme.js"));

            bundles.Add(new ScriptBundle("~/bundles/Admin")
                      .Include(

                      "~/Areas/Affiliate/Scripts/Ux/jquery.nanoscroller.js",
                      "~/Areas/Affiliate/Scripts/Ux/jquery.stickyheader.js",
                      "~/Areas/Affiliate/Scripts/popup.js",
                      "~/Areas/Affiliate/Scripts/Ux/parsley.min.js",
                      "~/Areas/Affiliate/Scripts/Ux/dateiso.js",
                      "~/Areas/Affiliate/Scripts/Ux/moment-with-locales.js",
                      "~/Areas/Affiliate/Scripts/Ux/bootstrap-datetimepicker.js",
                      "~/Areas/Affiliate/Scripts/date.js",
                      "~/Scripts/Ux/jquery.ba-throttle-debounce.min.js",
                      "~/Scripts/Ux/jquery.magnific-popup.js",
                      "~/Areas/Affiliate/Scripts/Ux/cleanzone.js",
                      "~/Areas/Affiliate/Scripts/initView.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/Ux/Detailmap")
                      .Include("~/Areas/Beneficiary/Scripts/App/map-Detail-reservation.js"));

            bundles.Add(new ScriptBundle("~/bundles/Ux/map")
                .Include("~/Scripts/App/map.js"));

            bundles.Add(new ScriptBundle("~/bundles/Ux/mapclient")
                .Include("~/Areas/Beneficiary/Scripts/App/map.js"));


            bundles.Add(new ScriptBundle("~/bundles/gallery")
                      .Include(
                        "~/Scripts/Ux/jquery.magnific-popup.js",
                        "~/Scripts/Ux/EasyResponsiveTabs.js",
                        "~/Scripts/Ux/widget.min.js",
                        "~/Scripts/Ux/bootstrap-rating.js",
                        "~/Scripts/App/app.js",
                        "~/Scripts/Ux/bootstrap-rating-input.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/galleryMobile")
                      .Include(
                        "~/Scripts/Ux/Gallery-Mobile.js",
                        "~/Scripts/Ux/imagemobile.js",
                        "~/Scripts/Ux/bootstrap-rating-input.js",
                        "~/Scripts/Ux/jquery.magnific-popup.js",
                        "~/Scripts/Ux/EasyResponsiveTabs.js",
                        "~/Scripts/Ux/widget.min.js",
                        "~/Scripts/App/app.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/parametre")
                      .Include(
                        "~/Areas/Beneficiary/Scripts/parametre.js"));

            bundles.Add(new ScriptBundle("~/bundles/Info")
                      .Include(
                        "~/Scripts/Ux/infobox.js"));

            bundles.Add(new ScriptBundle("~/bundles/Init")
                      .Include(
                        "~/Scripts/initView.js"));

            bundles.Add(new ScriptBundle("~/bundles/Ux")
                      .Include(
                        "~/Scripts/Ux/kitUtils.js",
                        "~/Scripts/Ux/jquery.flypanels.js",
                        "~/Scripts/Ux/flypanels-container.js",
                        "~/Scripts/Ux/fastclick.min.js",
                        "~/Scripts/Ux/jquerymobile.js",
                        "~/Scripts/Ux/Gallery-Mobile.js",
                        "~/Scripts/Ux/slider.js",
                        "~/Scripts/Ux/menu.js",
                        "~/Scripts/App/app.js",
                        "~/Scripts/App/switchsexe.js",
                        "~/Scripts/Ux/parsley.min.js",
                        "~/Scripts/Ux/jquery.magnific-popup.js",
                        "~/Areas/Affiliate/Scripts/popup.js",
                        "~/Scripts/Ux/EasyResponsiveTabs.js",
                        "~/Scripts/Ux/jquery.ba-throttle-debounce.min.js",
                        "~/Scripts/Ux/jquery.stickyheader.js",
                        "~/Scripts/Ux/widget.min.js",
                        "~/Scripts/Ux/tabs.min.js",
                        "~/Scripts/Ux/mouse.min.js",
                        "~/Scripts/Ux/jquery.isotope.min.js",
                        "~/Scripts/Ux/modernizr.custom.98434.js",
                        "~/Scripts/Ux/jquery.mixitup.min.js",
                        "~/Scripts/Ux/script.js",
                        "~/Scripts/Ux/jQRangeSlider-min.js",
                        "~/Scripts/Ux/BudgetSlider.js",
                        "~/Scripts/Ux/custom.js",
                        "~/Areas/Beneficiary/Scripts/Ux/rlaccordion.js",
                        "~/Areas/Beneficiary/Scripts/paiement.js"
                      ));
            BundleTable.EnableOptimizations = false;
        }
    }
}
