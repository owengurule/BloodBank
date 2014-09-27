using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBank.Controllers
{
    public class DonorController : Controller
    {
        //
        // GET: /Donor/
        BloodBank.Models.BloodBankEntities db = new Models.BloodBankEntities();

        public ActionResult Index()
        {
            return View(db.Donors);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Models.Donor());
        }

        [HttpPost]
        public ActionResult Create(Models.Donor donor)
        {
            db.Donors.Add(donor);
            db.SaveChanges();
            return RedirectToAction("Index", "Donor");
        }

        public ActionResult Details(int id)
        {
            return View(db.Donors.Find(id));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.BloodBanks.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Models.Donor Donor)
        {
            db.Entry(Donor).State = System.Data.EntityState.Modified;

            return RedirectToAction("Edit", "Donor");
        }
    }
}
