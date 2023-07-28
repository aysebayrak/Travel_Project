using CasgemTravel.DAL.Context;
using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemTravel.Controllers
{

    [Authorize]
    public class AdminGuideController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Guides.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            travelContext.Guides.Add(guide);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGuide(int id)
        {
            var values = travelContext.Guides.Find(id);
            travelContext.Guides.Remove(values);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var values = travelContext.Guides.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateGuide(Guide guide)
        {
            var values = travelContext.Guides.Find(guide.GuideID);
            values.GuideName = guide.GuideName;
            values.GuideTitle = guide.GuideTitle;
            values.GuideImageUrl = guide.GuideImageUrl;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
