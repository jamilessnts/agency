using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class FooterController : GlassController
    {
        // GET: Footer
        public ActionResult Footer()
        {
            var footer = this.GetDataSourceItem<Footer>();
            return View(footer);
        }
    }
}