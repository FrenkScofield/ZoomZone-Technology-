using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoomZone.Models
{
    public class SliderHome
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string SImage { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile UpPhoto { get; set; }
        }
}
