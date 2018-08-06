using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.About.Models
{
    public class TeamItem:SitecoreItem
    {
        public virtual Image Image { get; set; }
        public virtual string Fname { get; set; }
        public virtual string Job { get; set; }
        public virtual string Description { get; set; }
        public virtual Link Twitter { get; set; }
        public virtual Link Facebook { get; set; }
        public virtual Link Linkedin { get; set; }
    }
}