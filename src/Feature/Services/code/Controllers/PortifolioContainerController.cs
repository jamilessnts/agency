using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;

namespace Agency.Feature.Services.Controllers
{
    public class PortifolioContainerController : GlassController
    {
        // GET: PortifolioContainer
        public ActionResult PortifolioContainer()
        {
            var portifolioContainer = this.GetDataSourceItem<PortifolioContainer>();
            return View(portifolioContainer);
        }

        public ActionResult PortifolioItem()
        {
            var portifolioItem = this.GetDataSourceItem<PortifolioItem>();
            return View(portifolioItem);
        }
        
    }
}