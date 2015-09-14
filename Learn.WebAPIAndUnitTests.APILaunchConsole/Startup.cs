using Learn.WebAPIAndUnitTests.API;
using Microsoft.Owin;
using Owin;
using System.Net;
using System.Web.Http;

[assembly: OwinStartup(typeof(Learn.WebAPIAndUnitTests.APILaunchConsole.Startup))]

namespace Learn.WebAPIAndUnitTests.APILaunchConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpListener listener =
                (HttpListener)app.Properties["System.Net.HttpListener"];
            listener.AuthenticationSchemes =
                AuthenticationSchemes.IntegratedWindowsAuthentication;
            HttpConfiguration config = new HttpConfiguration();
            MyAPIConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
