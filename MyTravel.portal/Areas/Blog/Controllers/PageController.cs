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
        private readonly IMvcContext _mvcContext;

        public PageController(IMvcContext mvcContext)
        {
            _mvcContext = mvcContext;
        }

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

            ImageField imgField = sourceItem.Fields["Image"];
            if (imgField != null)
            {
                pageModel.ContentImage = new Glass.Mapper.Sc.Fields.Image()
                {
                    Src = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imgField.MediaItem)
                };
            }

            //return View("~/Areas/Blog/Views/Page/Home.cshtml");
            return View("~/Areas/Blog/Views/Page/Home.cshtml", pageModel);
        }

        public ActionResult News()
        {
            return View("~/Areas/Blog/Views/Page/News.cshtml");
        }

        public ActionResult Video()
        {
            var sourceItem = RenderingContext.Current.Rendering.Item;
            var pageModel = new VideoModel();
            pageModel.Title = sourceItem["Title"];
            pageModel.VideoURL = sourceItem["Video url"];

            DateField dateField = sourceItem.Fields["Date"];
            if (dateField != null)
            {
                pageModel.Date = dateField.DateTime;
            }

            return View("~/Areas/Blog/Views/Page/Video.cshtml", pageModel);
        }

        public ActionResult Contacts()
        {
            //Sitecore.Data.Items.Item homeItem = Sitecore.Context.Database.GetItem("/sitecore/content/Home");
            //if (homeItem != null)
            //{
            //    var children = new Sitecore.Collections.ChildList(homeItem);
            //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //    foreach (Sitecore.Data.Items.Item item in children)
            //    {
            //        sb.AppendLine(item.Paths.Path);
            //    }
            //}

            //var db = Sitecore.Configuration.Factory.GetDatabase("master");
            var item2 = Sitecore.Context.Database.GetItem("/sitecore/content/Home/News");
            Sitecore.Links.UrlOptions urlOptions = (Sitecore.Links.UrlOptions)Sitecore.Links.UrlOptions.DefaultOptions.Clone();
            urlOptions.SiteResolving = Sitecore.Configuration.Settings.Rendering.SiteResolving;
            String url = Sitecore.Links.LinkManager.GetItemUrl(item2, urlOptions);


            return View("~/Areas/Blog/Views/Page/Contacts.cshtml");
        }

        public ActionResult About()
        {
            //IMvcContext mvcContext = new MvcContext();
            var source = _mvcContext.GetContextItem<PageModel>();
            return View("~/Areas/Blog/Views/Page/About.cshtml", source);
        }
    }
}
