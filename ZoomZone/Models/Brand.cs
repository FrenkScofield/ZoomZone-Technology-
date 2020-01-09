﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public ICollection<CatBraPivot> CatBraPivots { get; set; }

    }
}
