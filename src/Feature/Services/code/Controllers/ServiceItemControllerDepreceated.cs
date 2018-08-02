using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;

namespace Agency.Feature.Services.Controllers
{
    public class ServiceItemControllerDepreceated : GlassController
    {
        // GET: ServiceItem
        public ActionResult ServiceItem()
        {
            var serviceItem = this.GetDataSourceItem<ServiceItem>();
            return View(serviceItem);
        }
    }
}