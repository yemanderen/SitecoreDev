using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravel.portal.Areas.Blog.Models.Configurations
{
    public class VideoModelMap : SitecoreGlassMap<VideoModel>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f=>f.Id);
                config.Field(f => f.Title).FieldId("{01DD9998-5E34-4C5C-ADBB-C16133AB8841}");
                config.Field(f => f.Date).FieldId("{1A54382B-80A9-43A3-99AF-B3A07852EEC5}");
                config.Field(f => f.VideoURL).FieldId("{3D174D2F-5CBD-4E02-BD59-08A5DAAEB172}");
                config.Field(f => f.Description).FieldId("{17807611-E26F-493C-A254-0FE17331FCF7}");
                config.Info(f => f.Name).InfoType(SitecoreInfoType.Name);
            });
        }
    }
}