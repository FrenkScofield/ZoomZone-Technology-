using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ZoomZone.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProColPivot> ProColPivots { get; set; } 
    }
}
