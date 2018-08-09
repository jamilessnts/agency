using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.ContactUs.Models;

namespace Agency.Feature.ContactUs.Controllers
{
    public class ContactController : GlassController
    {
        // GET: Contact
        public ActionResult ContactContainer()
        {
            var contactContainer = this.GetDataSourceItem<ContactContainer>();
            return View(contactContainer);
        }

        public ActionResult ContactForm()
        {
            var contactForm = this.GetDataSourceItem<ContactForm>();
            return View(contactForm);
        }
    }
}