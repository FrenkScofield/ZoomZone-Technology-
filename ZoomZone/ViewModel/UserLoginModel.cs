using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.ViewModel
{
    public class UserLoginModel
    {
        [Required]
        [Display(Name = "Email or Username")]
        public string EmailOrUsernaem { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }
}
