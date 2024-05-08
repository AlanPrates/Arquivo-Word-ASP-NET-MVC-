using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WordPrates.Models;

namespace WordPrates.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
