using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency.Feature.About.Models;

namespace Agency.Feature.About.Controllers
{
    public class ContactController : GlassController
    {
        // GET: Contact
        public ActionResult ContactContainer()
        {
            var contactContainer = this.GetDataSourceItem<ContactContainer>();
            return View(contactContainer);
        }

        //public ActionResult ContactForm()
        //{
        //    var contactForm = this.GetDataSourceItem<ContactForm>();
        //    return View(contactForm);
        //}
    }
}