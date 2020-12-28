using BlankCore.AdvancedTemplate;
using BlankCore.BasicTemplate;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlankSiteCore
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }


        public Startup(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var kenticoServiceCollection = services.AddKentico(features =>
            {
                features.UsePageBuilder();
                features.UsePageRouting();
            });

            kenticoServiceCollection.SetAdminCookiesSameSiteNone();
            kenticoServiceCollection.DisableVirtualContextSecurityForLocalhost();

            services.AddAuthentication();
            services.AddControllersWithViews();

            PageBuilderFilters.PageTemplates.Add(new BasicTemplateFilter());
            PageBuilderFilters.PageTemplates.Add(new AdvancedTemplateFilter());

            services.AddSingleton<CustomServiceForMessages>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseKentico();
            app.UseCookiePolicy();
            app.UseCors();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.Kentico().MapRoutes();

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller}/{action}"
                );
            });
        }
    }
}
