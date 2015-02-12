using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class List
    {
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public List<Weather> Weather { get; set; }
    }
}