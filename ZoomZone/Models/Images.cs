using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Images
    {
        public int Id { get; set; }
        [Required, StringLength(250)]
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        

    }
}