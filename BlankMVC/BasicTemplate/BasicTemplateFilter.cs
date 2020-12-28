using BlankMVC;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankMVC.BasicTemplate
{
    public class BasicTemplateFilter : IPageTemplateFilter
    {
        public IEnumerable<PageTemplateDefinition> Filter(IEnumerable<PageTemplateDefinition> pageTemplates, PageTemplateFilterContext context)
        {
            if (context.PageType.Equals(Registrations.PAGETYPE_BASIC, StringComparison.InvariantCultureIgnoreCase))
            {
                return pageTemplates.Where(t => GetAllowedTemplates().Contains(t.Identifier));
            }

            return pageTemplates.Where(t => !GetAllowedTemplates().Contains(t.Identifier));
        }

        public IEnumerable<string> GetAllowedTemplates() => new string[] { Registrations.TEMPLATE_BASIC, Registrations.TEMPLATE_ALTBASIC };
    }
}
