using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ZoomZone.DAL;
using ZoomZone.Extensions;
using ZoomZone.Models;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdvertisingController : Controller
    {
        private readonly ZZContext _context;
        private readonly IHostingEnvironment _env;
        public AdvertisingController(ZZContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

    //Indexc Section
        public IActionResult Index()
        {
            return View(_context.Advertisings);
        }

    //CRUD. Create section
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    // Create Post section
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Advertising photo)
        {
            if (ModelState.IsValid)
            {
                return View(photo);
            }

            //Save Photo
            if (!photo.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Image type is not valid");
                return View();
            }
            //Image type is ok, chek size
            if (photo.Photo.IsSmaller(1))
            {
                ModelState.AddModelError("Photo", "Image type can be maximom 1mb");
                return View();
            }
            //image size is ok, save the image
            photo.Image = await photo.Photo.SaveFileAsync(_env.WebRootPath, "img", "bg");

            await _context.Advertisings.AddRangeAsync(photo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    // Delete sction    
        public  async Task<IActionResult> Delete(int? id)
        {
            if (_context.Advertisings.Count() <= 2)
            {
                RedirectToAction(nameof(Index));
            }

            if (id == null) return NotFound();

            Advertising advertising = await _context.Advertisings.FindAsync(id);

            if (advertising == null) return NotFound();
           
            return View(advertising);
        }

    // Delete Post sction    
        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Advertising advertising = await _context.Advertisings.FindAsync(id);

            if (advertising == null) return NotFound();

            Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath,@"img",@"bg",advertising.Image);

           _context.Advertisings.Remove(advertising);

           await _context.SaveChangesAsync();

            TempData["success_message"] = "Advertising was removed successfully";
            return RedirectToAction(nameof(Index));
        }

    // Edit section
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Advertising advertising = await _context.Advertisings.FindAsync(id);

            if (advertising == null) return NotFound();

            return View(advertising);
        }

     // Edit Post section
        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(int? id, Advertising a)
        {
            
           Advertising advertising = await _context.Advertisings.FindAsync(id);

            if (advertising == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (a.UpPhoto != null)
            {
                if (!a.UpPhoto.IsImage())
                {
                    ModelState.AddModelError("UpPhoto", "Plase PHOTO file choose");
                    return View();
                }

                if (!a.UpPhoto.IsSmaller(1))
                {
                    ModelState.AddModelError("UpPhoto", "Plase PHOTO size maximum 1 mb must be");
                    return View();
                }

                string filName = await a.UpPhoto.SaveFileAsync(_env.WebRootPath, "img", "bg");
                Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath, @"img", @"bg", advertising.Image);
                advertising.Image = filName;

                advertising.Title = a.Title;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
