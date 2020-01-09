using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CatBraPivotId { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Memory { get; set; }
        [Required, StringLength(100)]
        public string RAM { get; set; }
        [Required, StringLength(100)]
        public string Camera { get; set; }
        [Required, StringLength(100)]
        public string Ghz { get; set; }
        [Required, StringLength(100)]
        public string DisplaySize { get; set; }
        [Required, StringLength(100)]
        public string Batary { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required, StringLength(100)]
        public string Processor { get; set; }
        [Required, StringLength(50)]
        public string OS { get; set; }
        [StringLength(50)]
        public string VideoCart { get; set; }
        [Required, StringLength(50)]
        public string ProductionDate { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public byte? Discount { get; set; }
        public DateTime DateTime { get; set; }

        public virtual CatBraPivot CatBraPivot { get; set; }
        public ICollection<Images> Images { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<ProColPivot> ProColPivots {get; set;}
    }
}
