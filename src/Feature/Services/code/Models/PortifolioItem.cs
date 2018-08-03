using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Services.Models
{
    public class PortifolioItem:SitecoreItem
    {
        public virtual Image Image { get; set; }
        public virtual string Title { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string TitleModal { get; set; }
        public virtual string SubtitleModal { get; set; }
        public virtual Image ImageModal { get; set; }
        public virtual string DescriptionModal { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Client { get; set; }
        public virtual string Category { get; set; }

    }
}