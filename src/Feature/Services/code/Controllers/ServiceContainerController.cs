using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;

namespace Agency.Feature.Services.Controllers
{
    public class ServiceContainerController : GlassController
    {
        // GET: ServiceContainer
        public ActionResult ServiceContainer()
        {
            var services = this.GetDataSourceItem<ServiceContainer>();
            return View(services);
            
        }

        public ActionResult ServiceItem()
        {
            var serviceItem = this.GetDataSourceItem<ServiceItem>();
            return View(serviceItem);
            //return View("~/Views/ServiceItem/ServicesItem.cshtml", serviceItem);

        }
    }
}