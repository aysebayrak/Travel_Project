using CasgemTravel.DAL.Context;
using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            ViewBag.travellist = travelContext.Travels.ToList();
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

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialBooking(Booking booking)
        {
            booking.BookingStatus = "Aktif";
            travelContext.Bookings.Add(booking);
            travelContext.SaveChanges();
            return PartialView();
        }

        public PartialViewResult PartialImages()
        {
            return PartialView();
        }

        public PartialViewResult PartialDestination()
        {
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialExplore()
        {
            return PartialView();
        }

        public PartialViewResult PartialBookingImage()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript2()
        {
            return PartialView();
        }
    }
}