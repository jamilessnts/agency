using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency.Feature.Media.Models;

namespace Agency.Feature.Media.Controllers
{
    public class PageFooterController : GlassController
    {
        // GET: PageFooter
        public ActionResult PageFooter()
        {
            var footer = this.GetDataSourceItem<PageFooter>();
            return View(footer);
        }
    }
}