using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bloog.Models;
using RestSharp;

namespace bloog.Controllers
{
    public class CitiesController : Controller
    {
        private BlogContext db = new BlogContext();
        //
        // GET: /Cities/
        public ActionResult Index()
        {
            return View(db.City.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                db.City.Add(city);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }
         

        public ActionResult Barcelona()
        {
            var client = new RestClient("http://127.0.0.1/Weather.php?city=barcelona");
            var request = new RestRequest(Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            RestResponse<WeatherData> response2 = (RestResponse<WeatherData>)client.Execute<WeatherData>(request);

            return View(response2.Data);
        }

        public ActionResult London()
        {
            var client = new RestClient("http://127.0.0.1/Weather.php?city=london");
            var request = new RestRequest(Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            RestResponse<WeatherData> response2 = (RestResponse<WeatherData>)client.Execute<WeatherData>(request);

            return View(response2.Data);
        }

        public ActionResult Copenhagen()
        {
            var client = new RestClient("http://127.0.0.1/Weather.php?city=copenhagen");
            var request = new RestRequest(Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            RestResponse<WeatherData> response2 = (RestResponse<WeatherData>)client.Execute<WeatherData>(request);

            return View(response2.Data);
        }

        public ActionResult Berlin()
        {
            var client = new RestClient("http://127.0.0.1/Weather.php?city=berlin");
            var request = new RestRequest(Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            RestResponse<WeatherData> response2 = (RestResponse<WeatherData>)client.Execute<WeatherData>(request);

            return View(response2.Data);
        }
	}
}