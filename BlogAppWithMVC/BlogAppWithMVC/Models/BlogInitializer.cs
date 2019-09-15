using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogAppWithMVC.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            /// <summary>
            /// Kategoriler
            /// </summary>
            /// <param name="context"></param>
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryName="C#"},
                new Category() {CategoryName="Asp.Net MVC"},
                new Category() {CategoryName="Asp.Net WebForm"},
                new Category() {CategoryName="Windows Form"}
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            /// <summary>
            /// Bloglar
            /// </summary>
            List<Blog> blogs = new List<Blog>()
            {
                new Blog() {
                    Title = "C# Hakkında",
                    Description = "Delegates Hakkında Açıklamalar",
                    AddedDate = DateTime.Now.AddDays(-10),
                    Confirmation = true,
                    MainPage = true,
                    Content = "Hosgeldiniz kardeslerim",
                    Image = "1.jpg",
                    CategoryId = 1
                },
                new Blog() {
                    Title = "C++ Hakkında",
                    Description = "Delegates Hakkında Açıklamalar",
                    AddedDate = DateTime.Now.AddDays(-5),
                    Confirmation = true,
                    MainPage = true,
                    Content = "Hosgeldiniz kardeslerim",
                    Image = "2.jpg",
                    CategoryId = 1
                },
                new Blog() {
                    Title = "Python Hakkında",
                    Description = "Delegates Hakkında Açıklamalar",
                    AddedDate = DateTime.Now.AddDays(-1),
                    Confirmation = true,
                    MainPage = false,
                    Content = "Hosgeldiniz kardeslerim",
                    Image = "3.jpg",
                    CategoryId = 2
                },
            };

            context.Blogs.AddRange(blogs);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}