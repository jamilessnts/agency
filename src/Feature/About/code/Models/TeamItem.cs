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
        public Image Image { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public Link Twitter { get; set; }
        public Link Facebook { get; set; }
        public Link Linkedin { get; set; }
    }
}