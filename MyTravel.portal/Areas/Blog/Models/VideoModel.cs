using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravel.portal.Areas.Blog.Models
{
    public class VideoModel : BasicItem
    {
        public virtual string Title { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual string VideoURL { get; set; }

        public virtual string Description { get; set; }
    }
}