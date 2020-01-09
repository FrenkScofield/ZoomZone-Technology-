using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZoomZone.Models;
using ZoomZone.DAL;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ZoomZone.Extensions;
using System.Security.Policy;
using Microsoft.AspNetCore.Authorization;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ZZContext _context;
        private readonly IHostingEnvironment _env;
        public SliderController(ZZContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
      //Admin Slider Page Show
        public IActionResult Slider()
        {
            return View(_context.SliderHomes);
        }
        //Slider Create Page Start
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Slider Post Create Page 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderHome photo)
        {
            if (ModelState.IsValid)
            {
                return View(photo);
            }
            //Save photo
            if (!photo.Photo.IsImage()) 
            {
                ModelState.AddModelError("Photo", "Image type is not valid");
                return View();
            }

            //image type is ok, chek size
            if(!photo.Photo.IsSmaller(1))
            {
                ModelState.AddModelError("Photo", "Image type can be maximom 1mb");
                return View();
            }
            //image size is ok ,  save the image
            photo.SImage = await photo.Photo.SaveFileAsync(_env.WebRootPath, "img","slider");

            await _context.SliderHomes.AddRangeAsync(photo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Slider));
        }

        //Slider Edit Page Start
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            SliderHome slider = await _context.SliderHomes.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        //Slider Post Edit Page
        [HttpPost,ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(int? id, SliderHome s)
        {
            SliderHome sliderdb = await _context.SliderHomes.FindAsync(id);

            if(sliderdb == null)
            {
                return RedirectToAction(nameof(Slider));
            }
            if (s.UpPhoto != null)
            {
                if (!s.UpPhoto.IsImage())
                {
                    ModelState.AddModelError("UpPhoto", "Plase PHOTO file choose");
                    return View();
                }
                if (!s.UpPhoto.IsSmaller(1))
                {
                    ModelState.AddModelError("UpPhoto", "Plase PHOTO size maximum 1 mb must be");
                    return View();
                }
                string filName = await s.UpPhoto.SaveFileAsync(_env.WebRootPath, "img", "slider");
                Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath,@"img",@"slider", sliderdb.SImage);
                sliderdb.SImage = filName;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Slider));
        }

        //Slider Delete Page Start
        public async Task<IActionResult>Delete(int? Id)
        {
            if (_context.SliderHomes.Count() <= 2)
            {
                return RedirectToAction(nameof(Slider));
            }
            if (Id == null) return NotFound();

            SliderHome sliderHome = await _context.SliderHomes.FindAsync(Id);

            if (sliderHome == null) return NotFound();

            return View(sliderHome);
        }

        //Slider Post Delete Page 
        [HttpPost ,ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            SliderHome sliderHome = await _context.SliderHomes.FindAsync(id);

            if (sliderHome == null) return NotFound();
          

            Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath,@"img",@"slider", sliderHome.SImage);

            _context.SliderHomes.Remove(sliderHome);

            await _context.SaveChangesAsync();

            TempData["success_message"] = "Slider was removed successfully";
            return RedirectToAction(nameof(Slider));
        }

        

    }
}