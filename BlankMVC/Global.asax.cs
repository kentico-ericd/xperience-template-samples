using System.Web.Optimization;
using System.Web.Routing;

using Kentico.Web.Mvc;

namespace BlankMVC
{
    public class BlankMVCApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Enables and configures selected Kentico ASP.NET MVC integration features
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            // Registers routes including system routes for enabled features
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Registers enabled bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolverConfig.Register();
        }
    }
}
