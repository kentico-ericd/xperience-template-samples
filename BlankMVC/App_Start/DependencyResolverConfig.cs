using System.Web;
using System.Web.Mvc;

using Autofac;
using Autofac.Integration.Mvc;

using Kentico.Content.Web.Mvc;
using Kentico.Web.Mvc;


namespace BlankMVC
{
    /// <summary>
    /// Registers required implementations to the Autofac container and set the container as ASP.NET MVC dependency resolver
    /// </summary>
    public static class DependencyResolverConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            ConfigureDependencyResolverForMvcApplication(builder);

            AttachCMSDependencyResolver(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }


        private static void ConfigureDependencyResolverForMvcApplication(ContainerBuilder builder)
        {
            // Enable property injection in view pages
            builder.RegisterSource(new ViewRegistrationSource());

            // Register web abstraction classes
            builder.RegisterModule<AutofacWebTypesModule>();

            // Register controllers
            builder.RegisterControllers(typeof(BlankMVCApplication).Assembly);
        }


        /// <summary>
        /// Configures Autofac container to use CMS dependency resolver in case it cannot resolve a dependency.
        /// </summary>
        private static void AttachCMSDependencyResolver(ContainerBuilder builder)
        {
            builder.RegisterSource(new CMSRegistrationSource());
        }


        private static bool IsCacheEnabled()
        {
            return !IsPreviewEnabled();
        }


        private static bool IsPreviewEnabled()
        {
            return HttpContext.Current.Kentico().Preview().Enabled;
        }
    }
}