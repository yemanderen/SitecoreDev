using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravel.portal.Areas.Blog.Models
{
    public class PageModel : BasicItem
    {
        //[SitecoreField(FieldId = "{74653420-A803-4EFE-8E9A-6AA48B3E0400}")]
        public virtual string PageHeader { get; set; }

        //[SitecoreField(FieldId = "{BE81BD4E-9949-4A46-B953-8DFFD36D9B37}")]
        public virtual string Body { get; set; }

        //[SitecoreField(FieldId = "{AEE8205B-4A0F-499E-9C45-6DBC1F0DD7D1}")]
        public virtual DateTime Date { get; set; }

        //[SitecoreField(FieldId = "{708020DE-7CD8-4234-99E9-AC1563E1C051}")]
        public virtual Image ContentImage { get; set; }
    }
}