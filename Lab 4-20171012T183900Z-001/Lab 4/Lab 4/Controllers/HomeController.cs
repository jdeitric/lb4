using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["currenttime"] = DateTime.Now.ToString("t");
            ViewData["date"] = DateTime.Now.ToString("d");
            return View();
            //DateTime.Now.ToShortTimeString();
        }
    }
}