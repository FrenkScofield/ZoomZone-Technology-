using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
  
        public IActionResult Login()
        {
            return View();
        }
    }
}