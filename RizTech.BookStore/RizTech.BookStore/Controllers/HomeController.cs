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
        public ViewResult Index()
        {
            Title = "Home";
            CustomProperty = "Custom Value";
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
