using ZoomZone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.ViewModel
{
    public class HomeModels
    {
        public IEnumerable<SliderHome> Images { get; set; }
        public List<IFormFile> Photo { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public SelectList CategorySelect { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int BrandId{ get; set; }

        public Brand Brand { get; set; }
        public SelectList BrendSelect { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<CatBraPivot> CatBraPivots { get; set;  }
        public CatBraPivot CatBraPivot { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Images> ImageProduct { get; set; }
        public Product Product { get; set; }
        public Images ImageProducts { get; set; }

    }
}
