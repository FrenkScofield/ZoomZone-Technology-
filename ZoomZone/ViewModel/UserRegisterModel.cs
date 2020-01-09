using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZoomZone.Models;

namespace ZoomZone.ViewModel
{
    public class UserRegisterModel
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


        public static implicit operator AppUser(UserRegisterModel registerModel)
        {
            return new AppUser
            {
                Name = registerModel.Name,
                SurName = registerModel .Surname,
                UserName = registerModel.Username,
                Email = registerModel.Email
            };
        }
    }
}
