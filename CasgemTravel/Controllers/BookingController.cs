using CasgemTravel.DAL.Context;
using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemTravel.Controllers
{
    public class BookingController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Bookings.Where(x => x.BookingStatus == "Aktif").ToList();
            return View(values);
        }

        public ActionResult DeleteBooking(int id)
        {
            var booking = travelContext.Bookings.Find(id);
            booking.BookingStatus = "Pasif";
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBooking(int id)
        {
            var updateBooking = travelContext.Bookings.Find(id);
            return View(updateBooking);
        }

        [HttpPost]
        public ActionResult UpdateBooking(Booking booking)
        {
            var updateBooking = travelContext.Bookings.Find(booking.BookingID);
            updateBooking.CustomerName = booking.CustomerName;
            updateBooking.Destination = booking.Destination;
            updateBooking.Duration = booking.Duration;
            updateBooking.Mail = booking.Mail;
            updateBooking.BookingDate = booking.BookingDate;
            travelContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}