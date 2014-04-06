// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Neudesic">
//   Copyright © 2014 Neudesic
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS_Demo
{
    using System.Web.Routing;

    using App.AngularJS_Demo.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
