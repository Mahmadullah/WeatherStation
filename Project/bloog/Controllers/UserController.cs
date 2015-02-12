using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bloog.Models;

namespace bloog.Controllers
{
    public class UserController : Controller
    {
        private BlogContext db = new BlogContext();
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            //ViewBag.CityId = new SelectList(db.City, "CityId", "CityName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Email")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            return View("index");
        }

	}
}