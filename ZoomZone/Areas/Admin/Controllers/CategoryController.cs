using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZoomZone.DAL;
using ZoomZone.Models;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ZZContext _context;

        public CategoryController(ZZContext context)
        {
            _context = context;

        }
        // Catagorys main page 
        public IActionResult CategoryIndex()
        {
            return View(_context.Categories);
        }

        // Categori  create function section START
        public IActionResult Create()
        {
            return View();
        }
        // Categori Post create function section
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( string name)
        {
            Category catagory = new Category()
            {
                Name = name
            };

          await  _context.Categories.AddAsync(catagory);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(CategoryIndex));
        }

        //Category edit Function Section START
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();

            return View(category);
        }

        //Category Post edit Function Section
        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost( Category category)
        {
            if (category == null) return NotFound();

          Category  categoryUpdate = await _context.Categories.FindAsync(category.Id);

            if (categoryUpdate == null) return NotFound();

            categoryUpdate.Name = category.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(CategoryIndex));
        }

        //Category DELETE Function Section START
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();

            return View(category);
     
        }

        //Category Post DELETE Function Section
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Category category = await _context.Categories.FindAsync(id);

            if (category == null) return NotFound();

             _context.Categories.Remove(category);

             await _context.SaveChangesAsync();

            return RedirectToAction(nameof(CategoryIndex));
        }
    }
}