using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class WeatherData
    {

        public string Name { get; set; }
        public Sys Sys { get; set; }
        public Main Main { get; set; }
        public Coord Coord { get; set; }
        public Wind Wind { get; set; }
        //public List<Weather> Weather { get; set; }
        public List<List> List { get; set; }
    }
}