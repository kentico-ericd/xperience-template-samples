using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

namespace BlankCore.AdvancedTemplate
{
    public class AdvancedTemplateProperties : IPageTemplateProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Inspirational message")]

        public string Message { get; set; } = "";
    }
}
