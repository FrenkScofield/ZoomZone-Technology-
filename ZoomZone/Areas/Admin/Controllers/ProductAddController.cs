using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoomZone.DAL;
using ZoomZone.Models;
using ZoomZone.ViewModel;
using Microsoft.AspNetCore.Http;
using ZoomZone.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace ZoomZone.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductAddController : Controller
    {
        private readonly ZZContext _context;
        private readonly IHostingEnvironment _env;

        public ProductAddController(ZZContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        //All products show Page
        public IActionResult ProductPage()
        {

            return View(_context.Products.Include(v => v.Images).OrderByDescending(p=>p.DateTime));
        }

        // New product addition page. START
        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.catagory = _context.Categories;
            ViewBag.brand = _context.Brands;
            return View();
        }

        // New Post product save section 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeModels homeModels)
        {
            if (!ModelState.IsValid)
            {
                return View(homeModels.Products);
            }

            List<IFormFile> files = new List<IFormFile>();

            //SAVE Photo section

            foreach (var item in homeModels.Photo)
            {
                if (!item.IsImage())
                {
                    ModelState.AddModelError("Photo", "Image is not valid");
                    return View(homeModels);
                }

                if (!item.IsSmaller(2))
                {
                    ModelState.AddModelError("Photo", "Image size can be maximom 2 mb");
                    return View(homeModels);
                }

                files.Add(item);
            }
            var CatPvId = await _context.CatBraPivots.FirstOrDefaultAsync(v => v.BrandId == homeModels.BrandId);
            //save info section
            await _context.Products.AddAsync(new Product
            {
                Name = homeModels.Product.Name,
                Price = homeModels.Product.Price,
                RAM = homeModels.Product.RAM,
                OS = homeModels.Product.OS,
                DisplaySize = homeModels.Product.DisplaySize,
                Discount = homeModels.Product.Discount,
                Description = homeModels.Product.Description,
                Memory = homeModels.Product.Memory,
                Batary = homeModels.Product.Batary,
                Camera = homeModels.Product.Camera,
                Ghz = homeModels.Product.Ghz,
                Processor = homeModels.Product.Processor,
                VideoCart = homeModels.Product.VideoCart,
                ProductionDate = homeModels.Product.ProductionDate,
                CatBraPivotId = CatPvId.Id,
                DateTime= DateTime.Now

            });
            await _context.SaveChangesAsync();
            var ProID = _context.Products.LastOrDefault().Id;

            foreach (var item in files)
            {
                var image = await item.SaveFileAsync(_env.WebRootPath, "img", "MyProduct");
                await _context.Images.AddAsync(new Images
                {
                    ProductId = ProID,
                    ImagePath = image
                });
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ProductPage));
        }

        // Search and filtering section functions START
        public async Task<JsonResult> SearchCategory(int? id)
        {
            if (id == null)
            {
                return Json(new
                {
                    status = 404
                });
            }
            return Json(new
            {
                status = 200,
                data = await _context.CatBraPivots.Where(b => b.CategoryId == id).Select(b => b.Brand).ToListAsync(),
                data2 = await _context.CatBraPivots.Where(b => b.CategoryId == id).Select(b => b.Brand).FirstOrDefaultAsync()
            });
        }

        // Products Edit Functions start
        public async Task<IActionResult> Edit(int? id)   //view bring section
        {
            if (id == null) return NotFound();

            HomeModels homeModels = new HomeModels();

            homeModels.Brands = await _context.Brands.ToListAsync();

            homeModels.Categories = await _context.Categories.ToListAsync();

            homeModels.BrendSelect = new SelectList(await _context.Brands.ToListAsync(), "Id", "Name");

            homeModels.CategorySelect = new SelectList(await _context.Categories.ToListAsync(), "Id", "Name");

            homeModels.Product = await _context.Products.Include(p => p.CatBraPivot).ThenInclude(ct => ct.Category)

                                                        .Include(p => p.CatBraPivot).ThenInclude(ct => ct.Brand)

                                                        .FirstOrDefaultAsync(p => p.Id == id);

            homeModels.ImageProduct = _context.Images.Where(pi => pi.ProductId == id).ToList();

            return View(homeModels);
        }

        // Update and Save Section 
        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(int id, HomeModels homeModels)
        {
            Product product = await _context.Products.FindAsync(id);

            // Product photo section update function

            if (product == null) return RedirectToAction(nameof(ProductPage));

            if (homeModels.Photo != null)
            {

                foreach (var item in homeModels.Photo)
                {
                    if (!item.IsImage())
                    {
                        ModelState.AddModelError("UpPhoto", "Plase PHOTO file choose");
                        return View();
                    }

                    if (!item.IsSmaller(2))
                    {
                        ModelState.AddModelError("UpPhoto", "Plase PHOTO size maximum 1 mb must be");
                        return View();
                    }
                }

                List<Images> img = await _context.Images.Where(i => i.ProductId == id).ToListAsync();

                foreach (var item in img)
                {
                    Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath, "img", "MyProduct", item.ImagePath);

                }
                _context.Images.RemoveRange(img);

               
                foreach (var item in homeModels.Photo)
                {
                    var image = await item.SaveFileAsync(_env.WebRootPath, "img", "MyProduct");
                    await _context.Images.AddAsync(new Images
                    {
                        ProductId = id,
                        ImagePath = image
                    });
                    await _context.SaveChangesAsync();
                }
            }
            // Product Info section Update Function

            {

                product.Name = homeModels.Product.Name;
                product.Price = homeModels.Product.Price;
                product.RAM = homeModels.Product.RAM;
                product.OS = homeModels.Product.OS;
                product.DisplaySize = homeModels.Product.DisplaySize;
                product.Discount = homeModels.Product.Discount;
                product.Description = homeModels.Product.Description;
                product.Memory = homeModels.Product.Memory;
                product.Batary = homeModels.Product.Batary;
                product.Camera = homeModels.Product.Camera;
                product.Ghz = homeModels.Product.Ghz;
                product.Processor = homeModels.Product.Processor;
                product.VideoCart = homeModels.Product.VideoCart;
                product.ProductionDate = homeModels.Product.ProductionDate;
                product.CatBraPivotId = homeModels.Product.CatBraPivotId;
                product.CatBraPivotId = _context.CatBraPivots.FirstOrDefault(cbp=>cbp.BrandId == homeModels.Product.CatBraPivot.BrandId && cbp.CategoryId == homeModels.Product.CatBraPivot.CategoryId).Id;


                await _context.SaveChangesAsync();
                

                return RedirectToAction(nameof(ProductPage));
            }
        }

        //Product Delete Function Start
        public async Task<IActionResult> Delete(int? id)
        {

            HomeModels homeModels = new HomeModels();

            homeModels.Brands = await _context.Brands.ToListAsync();

            homeModels.Categories = await _context.Categories.ToListAsync();

            homeModels.BrendSelect = new SelectList(await _context.Brands.ToListAsync(), "Id", "Name");

            homeModels.CategorySelect = new SelectList(await _context.Categories.ToListAsync(), "Id", "Name");

            homeModels.Product = await _context.Products.Include(p => p.CatBraPivot).ThenInclude(ct => ct.Category)

                                                        .Include(p => p.CatBraPivot).ThenInclude(ct => ct.Brand)

                                                        .FirstOrDefaultAsync(p => p.Id == id);

            homeModels.ImageProduct = _context.Images.Where(pi => pi.ProductId == id).ToList();


            return View(homeModels);
        }

        //Product Delete POST Function Start
        [HttpPost,ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
           
           Product product = await _context.Products.FindAsync(id);

            List<Images> images = _context.Images.Where(i => i.ProductId == product.Id).ToList();
            if (product == null) return NotFound();

            foreach (var item in images)
            {
            Utilities.Utility.DeleteImgFromFolder(_env.WebRootPath, @"img", @"MyProduct", item.ImagePath);

            }
            _context.Images.RemoveRange(images);

            await _context.SaveChangesAsync();

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ProductPage));
        }
    }
}