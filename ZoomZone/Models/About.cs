using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Title { get; set; }
        [Required]
        [StringLength(10000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile PhotoAbout { get; set; }

    }
}
