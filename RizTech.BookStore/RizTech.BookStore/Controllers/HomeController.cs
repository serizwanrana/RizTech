using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using RizTech.BookStore.Models;

namespace RizTech.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }
        //[ViewData]
        //public BookModel Book { get; set; } ViewData Attribute in Complex form
        public ViewResult Index()
        {
            Title = "Home";
            //ViewBag.Title = "M Rizwan";
            //dynamic data = new ExpandoObject();
            //data.Id = 1;
            //data.Name = "Rizwan Rana";
            //ViewBag.Data = data;
            //ViewBag.Type = new BookModel() { Id = 2, Author = "Sager"};

            //ViewData["Property1"] = "Rizwan Sager"; // This is ViewData
            //ViewData["Books"] = new BookModel() { Id = 2, Author = "Sager"};

            CustomProperty = "Custom Value";
            //Book = new BookModel() { Id = 1, Title = "Java book" }; ViewData Attribute in Complex form

            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Us";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact Us";
            return View();
        }
    }
}
