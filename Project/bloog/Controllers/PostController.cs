using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bloog.Models;
using RestSharp;

namespace bloog.Controllers
{
    public class PostController : Controller
    {
        private BlogContext db = new BlogContext();
        //
        // GET: /Post/
        public ActionResult Index()
        {
            var posts = db.Posts.Include(c => c.City);
            return View(posts.ToList());
        }

        public ActionResult About()
        {
            var client = new RestClient("http://api.openweathermap.org/data/2.5/find?q=Barcelona,es&units=metric");
            var request = new RestRequest(Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            RestResponse<WeatherData> response2 = (RestResponse<WeatherData>)client.Execute<WeatherData>(request);
            return View(response2.Data);
        }

        public ActionResult Details(int Id)
        {
            //db.Posts.Find(Id);
            //List<Post> myPosts = (List<Post>)Session["posts"];

            Post myPost = db.Posts.Find(Id);
            return View(myPost);
        }

        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.City, "CityId", "CityName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Body,CityId")] Post post)
        {
            if (ModelState.IsValid) {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("index");
            }

            ViewBag.CityId = new SelectList(db.City, "CityId", "CityName", post.CityId);
            return View(post);
        }

        public ActionResult Barcelona()
        {
            var posts = db.Posts.Include(c => c.City);
            return View(posts.ToList());
        }

        public ActionResult London()
        {
            var posts = db.Posts.Include(c => c.City);
            return View(posts.ToList());
        }

        public ActionResult Copenhagen()
        {
            var posts = db.Posts.Include(c => c.City);
            return View(posts.ToList());
        }

        public ActionResult Berlin()
        {
            var posts = db.Posts.Include(c => c.City);
            return View(posts.ToList());
        }

	}
}