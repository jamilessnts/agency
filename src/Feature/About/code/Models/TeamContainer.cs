using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class TeamContainer:SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
    }
}