using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class Clients: SitecoreItem
    {
        public virtual Image ImageClient { get; set; }
    }
}