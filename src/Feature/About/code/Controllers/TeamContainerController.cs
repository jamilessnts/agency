using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.About.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class TeamContainerController : GlassController
    {
        // GET: TeamContainer
        public ActionResult TeamContainer()
        {
            var teamContainer = this.GetDataSourceItem<TeamContainer>();
            return View(teamContainer);
        }

        public ActionResult TeamItem()
        {
            var teamItem = this.GetDataSourceItem<TeamItem>();
            return View(teamItem);
        }
    }
}