using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class ContactContainer:SitecoreItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
    }
}