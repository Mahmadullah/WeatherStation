using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class PostComment
    {
        public Post Post { get; set; }
        public Comment Comment { get; set; }
    }
}