// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRoute.cs" company="Neudesic">
//   Copyright © 2014 Neudesic
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS_Demo.Routing
{
    using System.Web.Routing;

    public class DefaultRoute : Route
    {
        public DefaultRoute()
            : base("{*path}", new DefaultRouteHandler())
        {
            this.RouteExistingFiles = false;
        }
    }
}
