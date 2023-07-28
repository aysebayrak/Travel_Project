using CasgemTravel.DAL.Context;
using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemTravel.Controllers
{
    public class AdminController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminList()
        {
            var admins = travelContext.Admins.ToList();
            return View(admins);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            travelContext.Admins.Add(admin);
            travelContext.SaveChanges();
            return RedirectToAction("AdminList");
        }
        public ActionResult DeleteAdmin(int id)
        {
            var deleteAdmin = travelContext.Admins.Find(id);
            travelContext.Admins.Remove(deleteAdmin);
            travelContext.SaveChanges();
            return RedirectToAction("AdminList");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminUpdate = travelContext.Admins.Find(id);
            return View(adminUpdate);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Admin admin)
        {
            var adminUpdate = travelContext.Admins.Find(admin.AdminID);
            adminUpdate.Username = admin.Username;
            adminUpdate.Password = admin.Password;
            travelContext.SaveChanges();
            return RedirectToAction("AdminList");
        }
    }
}