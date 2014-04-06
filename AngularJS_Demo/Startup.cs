// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="Neudesic">
//   Copyright © 2014 Neudesic
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

[assembly: Microsoft.Owin.OwinStartup(typeof(App.AngularJS_Demo.Startup))]

namespace App.AngularJS_Demo
{
    using Owin;


    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //// For more information on how to configure your application, visit:
            //// http://go.microsoft.com/fwlink/?LinkID=316888

            this.ConfigureAuth(app);
        }
    }
}
