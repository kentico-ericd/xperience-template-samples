using CMS.DocumentEngine;
using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Microsoft.AspNetCore.Mvc;

namespace BlankCore.AdvancedTemplate
{
    public class MyAdvancedController : Controller
    {
        private readonly IPageDataContextRetriever dataRetriever;

        public MyAdvancedController(IPageDataContextRetriever dataRetriever)
        {
            this.dataRetriever = dataRetriever;
        }

        public IActionResult Index()
        {
            var page = dataRetriever.Retrieve<TreeNode>().Page;

            // Do some cool stuff here

            return new TemplateResult();
        }
    }
}
