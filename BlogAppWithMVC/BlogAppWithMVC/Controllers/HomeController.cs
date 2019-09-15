using BlogAppWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogAppWithMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private BlogContext _context = new BlogContext();
        
        public ActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }
    }
}