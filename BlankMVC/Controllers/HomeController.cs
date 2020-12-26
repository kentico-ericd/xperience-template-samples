using System.Web.Mvc;

using BlankMVC.Controllers;

using CMS.Core;
using CMS.DocumentEngine;

using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;

//[assembly: RegisterPageRoute("NewSite.Home", typeof(HomeController))]

namespace BlankMVC.Controllers
{
    public class HomeController : Controller
    {
        // Uncomment when passing a model with page data to the view
        //private readonly IPageRetriever pageRetriever;

        //public HomeController()
        //{
        //    // Consider replacing the call with dependency injection. See the documentation for details on how to set up dependency injection in MVC.
        //    pageRetriever = Service.Resolve<IPageRetriever>();
        //}

        // GET: Home
        public ActionResult Index()
        {
            // See ~/App_Start/ApplicationConfig.cs, ~/Views/Shared/_Layout.cshtml and ~/Views/Home/Index.cshtml
            // In the administration UI, create a Page type with a namespace called 'NewSite', code name 'Home', and set its features to:
            //   Page builder = True
            //   URL = True
            //   Metadata = True
            // In the administration UI, create a Page utilizing the new Page type

            // Uncomment when passing a model with page data to the view
            // The following is an example of retrieving the current page, which can be used, e.g. to populate the model to view.
            //TreeNode page = pageRetriever.RetrieveCurrent<TreeNode>(cache => cache.Key($"{nameof(HomeController)}|home"));

            return View();
        }
    }
}