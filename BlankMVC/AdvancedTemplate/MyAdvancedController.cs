using CMS.DocumentEngine;
using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Web.Mvc;

namespace BlankMVC.AdvancedTemplate
{
    public class MyAdvancedController : PageTemplateController<AdvancedTemplateProperties>
    {
        private readonly IPageDataContextRetriever dataRetriever;
        private readonly IPageTemplatePropertiesRetriever pageTemplatePropertiesRetriever;

        public MyAdvancedController(IPageDataContextRetriever dataRetriever, IPageTemplatePropertiesRetriever pageTemplatePropertiesRetriever)
        {
            this.dataRetriever = dataRetriever;
            this.pageTemplatePropertiesRetriever = pageTemplatePropertiesRetriever;
        }

        public ActionResult Index()
        {
            var page = dataRetriever.Retrieve<TreeNode>().Page;
            var msg = pageTemplatePropertiesRetriever.Retrieve<AdvancedTemplateProperties>().Message;
            if(string.IsNullOrEmpty(msg))
            {
                // Get some data from an external API
                msg = $"The letter of the day is {Guid.NewGuid()}";
            }

            var model = new AdvancedTemplateViewModel
            {
                Message = msg,
                Page = page
            };
            
            return View("~/AdvancedTemplate/_Template.cshtml", model);
        }
    }
}
