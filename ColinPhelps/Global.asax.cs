using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ColinPhelps.App_Start;
using ColinPhelps.Controllers;
using System.Web.Optimization;

namespace ColinPhelps
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /*void Application_Error(object sender, EventArgs e)
        {
            // Grab information about the last error occurred 
            var exception = Server.GetLastError();

            // Clear the response stream 
            var httpContext = ((HttpApplication)sender).Context;
            httpContext.Response.Clear();
            httpContext.ClearError();
            httpContext.Response.TrySkipIisCustomErrors = true;

            // Manage to display a friendly view 
            InvokeErrorAction(httpContext, exception);

        }
        void InvokeErrorAction(HttpContext httpContext, Exception exception)
        {
            var routeData = new RouteData();
            routeData.Values["controller"] = "error";
            routeData.Values["action"] = "index";
            routeData.Values["exception"] = exception;
            using (var controller = new ErrorController())
            {
                ((IController)controller).Execute(
                new RequestContext(new HttpContextWrapper(httpContext), routeData));
            }
        }
    */}
}
