using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class Footer: SitecoreItem
    {
        public virtual string Copyright { get; set; }
        public virtual Link Twitter { get; set; }
        public virtual Link Facebook { get; set; }
        public virtual Link Linkedin { get; set; }
        public virtual Link Privacy { get; set; }
        [SitecoreField("Term of Use")]
        public virtual Link TermOfUse { get; set; }

    }
}