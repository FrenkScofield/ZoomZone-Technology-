using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoomZone.DAL;
using ZoomZone.Models;

namespace ZoomZone.Controllers
{
    public class CartController : Controller
    {
        private readonly ZZContext _context;

        public CartController(ZZContext context)
        {
            _context = context;
        }

        // Adding products to cart function START
        public async Task<IActionResult> Add(int id)
        {
            var cart = new List<CartItem>();


            var cartSession = HttpContext.Session.GetString("cart");

            if (cartSession != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartSession);

                if (cart.Any(p => p.ProductId == id))
                {
                    CartItem cartItem = cart.First(c => c.ProductId == id);
                    cartItem.Count++;
                }
                else
                {

                    var product = await _context.Products.Include(p => p.CatBraPivot.Brand)
                                                    .Include(i => i.Images)
                                                    .FirstOrDefaultAsync(p => p.Id == id);

                    cart.Add(new CartItem
                    {
                        BrandName = product.CatBraPivot.Brand.Name,
                        Name = product.Name,
                        Price = product.Price,
                        ProductId = product.Id,
                        Discount = product.Discount,
                        Image = product.Images.FirstOrDefault().ImagePath,
                        Count = 1
                    });
                }
            }
            else
            {
                var product = await _context.Products.Include(p => p.CatBraPivot.Brand)
                                                    .Include(i => i.Images)
                                                    .FirstOrDefaultAsync(p => p.Id == id);

                cart.Add(new CartItem
                {
                    BrandName = product.CatBraPivot.Brand.Name,
                    Name = product.Name,
                    Price = product.Price,
                    ProductId = product.Id,
                    Discount = product.Discount,
                    Image = product.Images.FirstOrDefault().ImagePath,
                    Count = 1
                });
            }


            string jsonList = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", jsonList);

            var DesObj = JsonConvert.DeserializeObject<List<CartItem>>(jsonList);
            return PartialView("ProductBasket_Partial", DesObj);


        }

        // Display function on page after adding product to cart START
        public IActionResult Checkout()
        {
            List<CartItem> cart = new List<CartItem>();

            var cartString = HttpContext.Session.GetString("cart");

            if (cartString != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartString);
            }

            return View(cart);
        }

        // Delete function of products in the basket START
        public IActionResult CheckDelete(int id)
        {
            List<CartItem> cart = new List<CartItem>();

            var cartSession = HttpContext.Session.GetString("cart");

            if (cartSession != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartSession);

                if (cart.Any(p => p.ProductId == id))
                {
                    var a = cart.FirstOrDefault(c => c.ProductId == id);
                    cart.Remove(a);
                }
            }

            string jsonList = JsonConvert.SerializeObject(cart);

            HttpContext.Session.SetString("cart", jsonList);

            var DesObj = JsonConvert.DeserializeObject<List<CartItem>>(jsonList);

            return RedirectToAction(nameof(Checkout));

        }

        //Proceed To PayPal button click on and finish process. START
        public IActionResult FinalStage()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Signin", "Account");
            }
        }
    }
}