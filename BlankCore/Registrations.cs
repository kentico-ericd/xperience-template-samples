using BlankCore.BasicTemplate;
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

namespace BlankCore
{
    public class Registrations
    {
    }
}
