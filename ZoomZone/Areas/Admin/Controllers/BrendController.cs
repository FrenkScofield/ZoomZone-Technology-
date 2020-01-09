using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZoomZone.DAL;
using ZoomZone.Models;
using ZoomZone.ViewModel;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BrendController : Controller
    {
        private readonly ZZContext _context;
        public BrendController(ZZContext context)
        {
            _context = context;
        }

        // Brands main page 
        public IActionResult BrendIndex()
        {
            return View(_context.Brands);
        }

        // Brands  create function section START
        public IActionResult Create()
        {
            ViewBag.catagory = _context.Categories;
            return View();
        }

        // Brands  Post create function section
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeModels homeModels)
        {
            if (homeModels.Brand == null) return NotFound();
            Brand brand = new Brand
            {
                Name = homeModels.Brand.Name,
            };
           await _context.Brands.AddAsync(brand);
           await  _context.SaveChangesAsync();

          await  _context.CatBraPivots.AddAsync(new Models.CatBraPivot
            {
                CategoryId = homeModels.CategoryId,
                BrandId = brand.Id
            });
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(BrendIndex));
        }

        //Brands edit Function Section START
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            HomeModels homeModels = new HomeModels();

            homeModels.Brand = await _context.Brands.FindAsync(id);

            if (homeModels == null) return NotFound();

            homeModels.CatBraPivot = _context.CatBraPivots.FirstOrDefault(v => v.BrandId == id);

           homeModels.Categories = await _context.Categories.ToListAsync();
            
            return View(homeModels);
        }

        //Brands Post edit Function Section
        [HttpPost,ValidateAntiForgeryToken]
        public  async Task<IActionResult> Edit(int? id, HomeModels homeModels)
        {
            homeModels.Category = await _context.Categories.FindAsync(homeModels.Category.Id);

            if (homeModels.Brand == null) return NotFound();

            CatBraPivot catBraPivotUP = await _context.CatBraPivots.FirstOrDefaultAsync(u=>u.BrandId==homeModels.Brand.Id);

            if (homeModels.Category == null) return RedirectToAction(nameof(BrendIndex));

            Brand brand = await _context.Brands.FindAsync(id);

            if (brand == null) return RedirectToAction(nameof(BrendIndex));

            //This section is required for the CarBraPivot table
            catBraPivotUP.BrandId = homeModels.Brand.Id;

            catBraPivotUP.CategoryId = homeModels.Category.Id;

           await _context.SaveChangesAsync();


            //This section is required for the Brand table
            brand.Name = homeModels.Brand.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(BrendIndex));
        }

        //Brand  DELETE section function START
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            HomeModels homeModels = new HomeModels();

            homeModels.Brand = await _context.Brands.FindAsync(id);

            if (homeModels == null) return NotFound();

            homeModels.CatBraPivot = _context.CatBraPivots.FirstOrDefault(c => c.BrandId == id);

            return View(homeModels);
        }

        //Brand Post  DELETE section function
        [HttpPost,ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost( int? id)
        {
            if (id == null) return NotFound();

            HomeModels homeModels = new HomeModels();

            if (homeModels == null) return NotFound();

            homeModels.CatBraPivot =  _context.CatBraPivots.FirstOrDefault(i => i.BrandId == id); ;

            _context.CatBraPivots.Remove(homeModels.CatBraPivot);

            await _context.SaveChangesAsync();

            homeModels.Brand =  _context.Brands.FirstOrDefault(b=>b.Id == id);

            _context.Brands.Remove(homeModels.Brand);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(BrendIndex));
        }
       




    }
}