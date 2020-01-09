using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class AppUser :IdentityUser
    {
       
        [Required, StringLength(200)]
        public string Name { get; set; }
        [ StringLength(200)]
        public string SurName { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
