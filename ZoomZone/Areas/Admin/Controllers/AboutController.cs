using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ZoomZone.DAL;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly ZZContext _context;
        private readonly IHostingEnvironment _env;
        public AboutController(ZZContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult AboutAdminPage()
        {
            return View(_context.Abouts);
        }
    }
}