using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual AppUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
