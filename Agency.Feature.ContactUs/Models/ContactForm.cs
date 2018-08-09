using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.ContactUs.Models
{
    public class ContactForm:SitecoreItem
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}