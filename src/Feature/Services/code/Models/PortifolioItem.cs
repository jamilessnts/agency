using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Agency.Feature.Services.Models
{
    public class PortifolioItem:SitecoreItem
    {
        public virtual Image Image { get; set; }
        public virtual string Client { get; set; }
        public virtual string Category { get; set; }
        [SitecoreField("Project Name")]
        public virtual string ProjectName { get; set; }
        [SitecoreField("Subtitle Name")]
        public virtual string SubtitleName { get; set; }
        public virtual Image ImageModal { get; set; }
        public virtual string DescriptionModal { get; set; }
        public virtual DateTime Date { get; set; }
        

    }
}