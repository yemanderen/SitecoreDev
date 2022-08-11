using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravel.portal.Areas.Blog.Models.Configurations
{
    public class PageModelMap:SitecoreGlassMap<PageModel>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f=>f.Id);
                config.Field(f => f.PageHeader).FieldId("{74653420-A803-4EFE-8E9A-6AA48B3E0400}");
                config.Field(f => f.Body).FieldId("{BE81BD4E-9949-4A46-B953-8DFFD36D9B37}");
                config.Field(f => f.Date).FieldId("{AEE8205B-4A0F-499E-9C45-6DBC1F0DD7D1}");
                config.Field(f => f.ContentImage).FieldId("{708020DE-7CD8-4234-99E9-AC1563E1C051}");
                config.Info(f => f.Name).InfoType(SitecoreInfoType.Name);
            });
        }
    }
}