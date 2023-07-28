using CasgemTravel.DAL.Context;
using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemTravel.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext = new TravelContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialForm()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialForm(Contact contact)
        {
            contact.MessageDate = DateTime.Now;
            travelContext.Contacts.Add(contact);
            travelContext.SaveChanges();
            return View("Index");
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript2()
        {
            return PartialView();
        }
    }
}