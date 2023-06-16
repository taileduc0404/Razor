using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System;
using System.Diagnostics;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
        //    Product product = new Product()
        //    {
        //        ProductId = 1,
        //        ProductName = "Kayak",
        //        ProductDescription = "This is decription the test!",
        //        Category = "Watersports",
        //        Price = 175M
        //    };
        Product[] array =
        {
            new Product { ProductName = "Kayak", Price = 275M },
			new Product { ProductName = "Lifejacket", Price = 48.95M },
			new Product { ProductName = "Soccer Ball", Price = 19.50M },
			new Product { ProductName = "Corner Flag", Price = 34.95M }

		};
        return View(array);
        } 
    }
}