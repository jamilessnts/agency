using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Services.Models
{
    public class ServiceItem: SitecoreItem
    {
        public Image ImagemIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}