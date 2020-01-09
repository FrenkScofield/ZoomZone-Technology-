using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZoomZone.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutViewPage()
        {
            return View();
        }
    }
}