using BlankMVC.BasicTemplate;
using BlankMVC.AdvancedTemplate;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace BlankMVC
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {
            builder.UsePageBuilder();
            builder.UsePageRouting();

            PageBuilderFilters.PageTemplates.Add(new BasicTemplateFilter());
            PageBuilderFilters.PageTemplates.Add(new AdvancedTemplateFilter());
        }
    }
}