using BlankCore;
using BlankCore.AdvancedTemplate;
using BlankCore.BasicTemplate;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

#region "Page templates - Basic"

[assembly: RegisterPageTemplate(Registrations.TEMPLATE_BASIC,
    "Basic template",
    typeof(BasicTemplateProperties),
    "~/BasicTemplate/_Template.cshtml",
    IconClass = "icon-chevron-up")]
[assembly: RegisterPageTemplate(Registrations.TEMPLATE_ALTBASIC,
    "Alt basic template",
    customViewName: "~/BasicTemplate/_AltTemplate.cshtml",
    IconClass = "icon-chevron-up-circle")]

#endregion

#region "Page templates - Advanced"

[assembly: RegisterPageTemplate(Registrations.TEMPLATE_ADVANCED,
    "Advanced template",
    typeof(AdvancedTemplateProperties),
    "~/AdvancedTemplate/_Template.cshtml",
    IconClass = "icon-chevron-double-up")]
[assembly: RegisterPageTemplate(Registrations.TEMPLATE_ADVANCEDSERVICE,
    "Advanced template with service",
    typeof(AdvancedTemplateProperties),
    "~/AdvancedTemplate/_TemplateWithService.cshtml",
    IconClass = "icon-plus-circle")]

#endregion

#region "Controllers - Advanced routes"

[assembly: RegisterPageRoute(Registrations.PAGETYPE_ADVANCED, typeof(MyAdvancedController), ActionName = "Index")]

#endregion

namespace BlankCore
{
    public static class Registrations
    {
        #region "Constants"

        public const string PAGETYPE_ADVANCED = "TemplatePage.Advanced",
                            PAGETYPE_BASIC = "TemplatePage.Basic",
                            TEMPLATE_BASIC = "BasicTemplate",
                            TEMPLATE_ALTBASIC = "AltBasicTemplate",
                            TEMPLATE_ADVANCED = "AdvancedTemplate",
                            TEMPLATE_ADVANCEDSERVICE = "AdvancedTemplateService";

        #endregion
    }
}
