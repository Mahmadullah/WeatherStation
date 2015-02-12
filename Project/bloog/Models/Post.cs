using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bloog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [Required (ErrorMessage = "You must put a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must explain it.")]
        public string Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual int CityId { get; set; }
        public virtual City City { get; set; }
    }
}