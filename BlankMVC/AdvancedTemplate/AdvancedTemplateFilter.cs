using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankMVC.AdvancedTemplate
{
    public class AdvancedTemplateFilter : IPageTemplateFilter
    {
        public IEnumerable<PageTemplateDefinition> Filter(IEnumerable<PageTemplateDefinition> pageTemplates, PageTemplateFilterContext context)
        {
            if (context.PageType.Equals(Registrations.PAGETYPE_ADVANCED, StringComparison.InvariantCultureIgnoreCase))
            {
                return pageTemplates.Where(t => GetAllowedTemplates().Contains(t.Identifier));
            }

            return pageTemplates.Where(t => !GetAllowedTemplates().Contains(t.Identifier));
        }

        public IEnumerable<string> GetAllowedTemplates() => new string[] { Registrations.TEMPLATE_ADVANCED };
    }
}
