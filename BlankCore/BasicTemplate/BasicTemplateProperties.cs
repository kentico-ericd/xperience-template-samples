using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

namespace BlankCore.BasicTemplate
{
    public class BasicTemplateProperties : IPageTemplateProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Background color")]
        public string Color { get; set; } = "#fff";
    }
}
