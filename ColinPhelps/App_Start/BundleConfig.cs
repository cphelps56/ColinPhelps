using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ColinPhelps.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new StyleBundle("~/bundles/sitecss").Include("~/Content/Site.css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapscripts", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js",
                "~/Scripts/modernizr-2.6.2.js")
                );

            bundles.Add(new StyleBundle("~/bundles/fontawesome", "https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css")
                .Include("~/bundles/fontawesome")
                );

            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/3..1/jquery.min.js")
                .Include("~/Scripts/jquery-3.1.1.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/javascript")
                .Include("~/Scripts/AnalyticsScripts.js")
                );

            BundleTable.EnableOptimizations = true;
        }
    }
}