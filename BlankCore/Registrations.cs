using BlankCore.AdvancedTemplate;
using BlankCore.BasicTemplate;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

#region "Page templates - Basic"

[assembly: RegisterPageTemplate("BasicTemplate",
    "Basic template",
    typeof(BasicTemplateProperties),
    "~/BasicTemplate/_Template.cshtml",
    IconClass = "icon-chevron-up")]
[assembly: RegisterPageTemplate("AltBasicTemplate",
    "Alt basic template",
    customViewName: "~/BasicTemplate/_AltTemplate.cshtml",
    IconClass = "icon-chevron-up-circle")]

#endregion

#region "Controllers - Advanced routes"

[assembly: RegisterPageRoute("TemplatePage.Advanced", typeof(MyAdvancedController), ActionName = "Index")]

#endregion

namespace BlankCore
{
    public class Registrations
    {
    }
}
