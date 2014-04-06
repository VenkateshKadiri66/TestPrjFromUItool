// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Neudesic">
//   Copyright © 2014 Neudesic
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS_Demo
{
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class Application : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
