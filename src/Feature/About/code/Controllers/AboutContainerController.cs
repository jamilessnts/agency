using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class AboutContainerController : GlassController
    {
        // GET: AboutContainer
        public ActionResult AboutContainer()
        {
            var aboutContainer = this.GetDataSourceItem<AboutContainer>();
            return View(aboutContainer);
        }
    }
}