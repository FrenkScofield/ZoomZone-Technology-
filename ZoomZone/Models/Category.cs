using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name {get; set;}
        public ICollection<CatBraPivot> CatBraPivots { get; set; }



    }
}
