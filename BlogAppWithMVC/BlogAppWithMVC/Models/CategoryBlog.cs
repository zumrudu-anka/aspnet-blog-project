using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppWithMVC.Models
{
    public class CategoryBlog
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public int blogCount { get; set; }
    }
}