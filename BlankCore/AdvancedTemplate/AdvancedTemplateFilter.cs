using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankCore.AdvancedTemplate
{
    public class AdvancedTemplateFilter : IPageTemplateFilter
    {
        public IEnumerable<PageTemplateDefinition> Filter(IEnumerable<PageTemplateDefinition> pageTemplates, PageTemplateFilterContext context)
        {
            if (context.PageType.Equals("TemplatePage.Advanced", StringComparison.InvariantCultureIgnoreCase))
            {
                return pageTemplates.Where(t => GetAllowedTemplates().Contains(t.Identifier));
            }

            return pageTemplates.Where(t => !GetAllowedTemplates().Contains(t.Identifier));
        }

        public IEnumerable<string> GetAllowedTemplates() => new string[] { "AdvancedTemplate", "AdvancedTemplateWithService" };
    }
}
