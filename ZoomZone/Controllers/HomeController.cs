using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoomZone.DAL;
using ZoomZone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq.Expressions;

namespace ZoomZone.Controllers
{
    public class HomeViewModel
    {
        public IEnumerable<SliderHome> SliderHomes { get; set; }
        public IEnumerable<Advertising> Advertisings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> LodMorProducts { get; set; }
        public IEnumerable<CatBraPivot> CatBraPivots { get; set; }
        public CatBraPivot CatBraPivot { get; set; }
        public IEnumerable<Images> Images { get; set; }
        public IEnumerable<ProColPivot> ProColPivots { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public Product Product { get; set; }

        public List<Like> Likes { get; set; }




    }

    public class HomeController : Controller
    {
        private readonly ZZContext _context;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(ZZContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Home page views
        public IActionResult Index()
        {
            
            HomeViewModel ImageModel = new HomeViewModel
            {
                SliderHomes = _context.SliderHomes.ToList(),
                Advertisings = _context.Advertisings.ToList(),
                Categories = _context.Categories.ToList(),
                Brands = _context.Brands.ToList(),
                CatBraPivots = _context.CatBraPivots.ToList(),
                Products = _context.Products.Include(v => v.Images).ToList(),
                LodMorProducts = _context.Products.Take(8).OrderByDescending(p=>p.DateTime).ToList(),
                Images = _context.Images.ToList(),
                ProColPivots = _context.ProColPivots.ToList(),
                Colors = _context.Colors.ToList(),
                Likes = _context.Likes.ToList()

            };
            //code used to show the number of all products in the database
            ViewData["Total_Product_count"] = _context.Products.Count();
            return View(ImageModel);
        }

        // Search and filtering section functions
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
                data = await _context.CatBraPivots.Where(b => b.CategoryId == id).Select(b => b.Brand).ToListAsync()
            });
        }

        //Bringing products to the page with ajax
        [HttpPost]
        public async Task<IActionResult> ProductAjax(int? categoryId, int? brendId)
        {
            HomeViewModel homeViewModel;

            homeViewModel = new HomeViewModel();

            var pivotId = await _context.CatBraPivots.FirstOrDefaultAsync(w => w.CategoryId == categoryId && w.BrandId == brendId);


            IQueryable<Product> products = _context.Products.Where(w => w.CatBraPivotId == pivotId.Id).Include(i => i.Images)
                .Include(p=>p.Likes)

            .Include(i => i.ProColPivots).ThenInclude(color => color.Color);

            homeViewModel.LodMorProducts = products.ToList();



            return PartialView("Product_Partial", homeViewModel);
        }

        // Popup display functions of products
        public async Task<IActionResult> popup(int? id)
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Product = await _context.Products
                .Include(i => i.Images)
                .Include(c => c.CatBraPivot)
                .FirstOrDefaultAsync(v => v.Id == id)
            };
            return PartialView("Popup_Partial", homeViewModel);
        }
        // Search by name and price Start
        public JsonResult SearchProduct(string name)
        {
            var jsonData = (from i in _context.Images
                            join p in _context.Products
                            on i.ProductId equals p.Id
                            where p.Name.Contains(name) || p.Price.ToString().Contains(name)
                            
                            select new
                            {
                                id = p.Id,
                                Name = p.Name,
                                Image = i.ImagePath,
                                price = p.Price
                            }).GroupBy(e => e.id).ToList();
            var AllProduc = (from i in _context.Images
                             join p in _context.Products
                             on i.ProductId equals p.Id
                             select new
                             {
                                 id = p.Id,
                                 Name = p.Name,
                                 Image = i.ImagePath,
                                 price = p.Price
                             }).ToList();
            if (name != null)
            {
                return Json(jsonData);
            }
            else
            {
                return Json(AllProduc);
            }

        }

        //Load More button clicked, the arrival of other products
        [HttpPost]
        public IActionResult LodMoreProducts(int count)
        {
            HomeViewModel ImageModel = new HomeViewModel
            {
                CatBraPivots = _context.CatBraPivots.ToList(),
                Products = _context.Products.Include(v => v.Images).ToList(),
                LodMorProducts = _context.Products.OrderByDescending(v=>v.DateTime).Skip(count).Take(8),
                Images = _context.Images.ToList(),
                Likes = _context.Likes.ToList()

            };

            ViewData["Total_Product_count"] = _context.Products.Count();


            return PartialView("Product_Partial", ImageModel);
        }

        //Like Section Start 

        [HttpPost]
        public async Task<IActionResult> LikePost(int proId)
        {

            var us = await _userManager.FindByNameAsync(User.Identity.Name);
            var LikeBool = await _context.Likes.FirstOrDefaultAsync(v => v.ProductId == proId);

            if (LikeBool==null)
            {
                _context.Likes.Add(new Like
                {
                    UserId = us.Id,
                    ProductId = proId
                });
                await _context.SaveChangesAsync();
                return Json(new
                {
                    success = 200,

                });
            }
            _context.Likes.Remove(LikeBool);
            await _context.SaveChangesAsync();
            return Json(new
            {
                success = 300,

            });


        }

        //Like Section End 


    }
}