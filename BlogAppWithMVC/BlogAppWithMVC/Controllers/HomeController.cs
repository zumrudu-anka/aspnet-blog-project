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
            IEnumerable<BlogModel> bloglar = _context.Blogs.Select(i => new BlogModel
            {
                Id = i.Id,
                Title = i.Title.Length > 100 ? i.Title.Substring(0,100) : i.Title,
                Description = i.Description,
                Content = i.Content,
                Image = i.Image,
                AddedDate = i.AddedDate,
                Confirmation = i.Confirmation,
                MainPage = i.MainPage
            }).
            Where(i => i.MainPage == true && i.Confirmation == true);

            return View(bloglar);
        }
    }
}