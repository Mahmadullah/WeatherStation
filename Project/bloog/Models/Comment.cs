using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; }

    }
}