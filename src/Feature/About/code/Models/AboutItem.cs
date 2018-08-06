using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class AboutItem:SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Description { get; set; }
        public virtual Image Image { get; set; }
        public virtual bool Inverted { get; set; }
    }
}