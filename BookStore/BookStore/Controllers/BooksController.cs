using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "learning ASP.NET Core2.0",
                Genre = "Programming & Software development",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors = new List<string> { "Jason De Oliveira", "Michel Bruchet" }
            };
            return View(book);
        }

        
            
        
    }
}
