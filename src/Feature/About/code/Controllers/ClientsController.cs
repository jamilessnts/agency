using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency.Feature.About.Models;

namespace Agency.Feature.About.Controllers
{
    public class ClientsController : GlassController
    {
        // GET: Sponsor
        public ActionResult ClientContainer()
        {
            var clientContainer = this.GetDataSourceItem<Clients>();
            return View(clientContainer);
        }


        public ActionResult Clients()
        {
            var clients = this.GetDataSourceItem<Clients>();
            return View(clients);
        }
    }
}