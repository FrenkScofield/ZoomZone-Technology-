using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }

        public virtual Product Product {get; set;}
        public virtual AppUser User { get; set; }
    }
}
