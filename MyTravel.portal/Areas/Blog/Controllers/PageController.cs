using Glass.Mapper.Sc.Web.Mvc;
using MyTravel.portal.Areas.Blog.Models;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTravel.portal.Areas.Blog.Controllers
{
    public class PageController : Controller
    {
        // GET: Blog/Page
        public ActionResult Home()
        {
            var sourceItem = RenderingContext.Current.Rendering.Item;
            var pageModel = new PageModel();
            pageModel.PageHeader = sourceItem["PageHeader"];
            pageModel.Body = sourceItem["Body"];

            DateField dateField = sourceItem.Fields["Date"];
            if (dateField != null)
            {
                pageModel.Date = dateField.DateTime;
            }

            //return View("~/Areas/Blog/Views/Page/Home.cshtml");
            return View("~/Areas/Blog/Views/Page/Home.cshtml", pageModel);
        }

        public ActionResult News()
        {
            return View("~/Areas/Blog/Views/Page/News.cshtml");
        }

        public ActionResult Contacts()
        {
            return View("~/Areas/Blog/Views/Page/Contacts.cshtml");
        }

        public ActionResult About()
        {
            IMvcContext mvcContext = new MvcContext();
            var source = mvcContext.GetContextItem<PageModel>();
            return View("~/Areas/Blog/Views/Page/About.cshtml", source);
        }
    }
}
