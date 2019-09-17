using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppWithMVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }
        public bool Confirmation { get; set; }
        public bool MainPage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}