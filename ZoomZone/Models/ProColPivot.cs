using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class ProColPivot
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; } 
    }
}
