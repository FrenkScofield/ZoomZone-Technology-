using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoomZone.DAL;
using ZoomZone.ViewModel;

namespace ZoomZone.Controllers
{
    public class ProductDetaileController : Controller
    {
        private readonly ZZContext _context;

        public ProductDetaileController(ZZContext context)
        {
            _context = context;
        }
        public IActionResult DetaileProduc(int? id)
        {

            HomeModels homeModels = new HomeModels();

            homeModels.Product = _context.Products.Include(i => i.Images).FirstOrDefault(d => d.Id == id);
            homeModels.Products = _context.Products.Include(v => v.Images).ToList();

            return View(homeModels);
        }

      
    }
}