using Microsoft.AspNetCore.Mvc;
using Razor.Models;
using System.Diagnostics;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Kayak",
                ProductDescription = "This is decription the test!",
                Category = "Watersports",
                Price = 175M
            };
            ViewBag.StockLevel = 2;
            return View(product);
        }

       
    }
}