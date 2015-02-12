using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}