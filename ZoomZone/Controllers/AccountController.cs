using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ZoomZone.DAL;
using ZoomZone.Models;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using ZoomZone.ViewModel;
using ZoomZone.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using System.Text;
using Microsoft.AspNetCore.WebUtilities;

namespace ZoomZone.Controllers
{
    public class AccountController : Controller
    {
        private readonly ZZContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender; 


        public AccountController(ZZContext context,
                               UserManager<AppUser> userManager,
                               SignInManager<AppUser> signInManager,
                               RoleManager<IdentityRole> roleManager,
                               IEmailSender emailSender )
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        //User Register Page Start
        public IActionResult Register()
        {
            return View();
        }

        //User Post Register Page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }
            AppUser user = registerModel;

           IdentityResult result = await _userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerModel);
            }


            // email confirmation
            //SMTP - Sinple Mail Transfer  Protocol

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            //64 byte array conversion part
            byte[] tokenGeneratedBytes = Encoding.UTF8.GetBytes(token);
            var codeEncoded = WebEncoders.Base64UrlEncode(tokenGeneratedBytes);

            await _emailSender.SendEmailAsync(registerModel.Email, "Conform your email",

                 $"Confirm your account by following to " +
                $"<a href='{HtmlEncoder.Default.Encode($"https://localhost:44335/Account/Conformemail?token={codeEncoded}&userId={user.Id}")}'>" +
                "this link" +
                $"</a>");

            return View("VerifyEmail");
        }

        //Sending mail to user section Start
        public async Task<IActionResult> Conformemail( string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if(user != null)
            {
                var codeDecodedBytes = WebEncoders.Base64UrlDecode(token);
                var codeDecoded = Encoding.UTF8.GetString(codeDecodedBytes);

                IdentityResult result = await _userManager.ConfirmEmailAsync(user, codeDecoded);

                if (result.Succeeded)
                {
                    return View();
                }

            }

            return View("FailedConfirmation");
        }

        //User signin Section Start
        public IActionResult Signin()
        {
            return View();
        }

        //User Post signin Section 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(UserLoginModel userLoginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginModel);
            }

            AppUser user = await _userManager.FindByEmailAsync(userLoginModel.EmailOrUsernaem);

            if(user == null)
            {
                user = await _userManager.FindByNameAsync(userLoginModel.EmailOrUsernaem);
            }

            if(user == null)
            {
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(userLoginModel);
            }

            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError("", "Your Email is not confirmet yet. Please, check your email");
                return View(userLoginModel);
            }

         var result =  await _signInManager.PasswordSignInAsync(user, userLoginModel.Password, userLoginModel.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email or Password is invalid");
            return View(userLoginModel);
        }

        //User Signout Section Start
        public IActionResult Signout()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        //User Forgot Passwort Section Start
        public IActionResult ForgotPassword()
        {
            return View();
        }

        //User Forgot Post Passwort Section
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(string email)
        {
          var user =  await _userManager.FindByEmailAsync(email);

            if(user == null)
            {
                ViewBag.EmailError = "Email doesn't exist in our database";
                return View();
            }

            string token = await _userManager.GeneratePasswordResetTokenAsync(user);

            //64 byte array conversion part
            byte[] tokenGeneratedBytes = Encoding.UTF8.GetBytes(token);
            var codeEncoded = WebEncoders.Base64UrlEncode(tokenGeneratedBytes);

            await _emailSender.SendEmailAsync(email, "Reset Password",

                 $"Follow the link to reset your password  " +
                $"<a href='{HtmlEncoder.Default.Encode($"https://localhost:44335/Account/ResetPassword?token={codeEncoded}&userId={user.Id}")}'>" +
                "this link" +
                $"</a>");

            return View("VerifyEmail");
        }

        //User Password Reset section Start
        public IActionResult ResetPassword(string token, string userId)
        {
            var model = new UserRessetPasswordModel
            {
                Token = token,
                UserId =userId

            };
            return View(model);
        }

        //User Password Reset Post section
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(UserRessetPasswordModel userRessetPasswordModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "New password is not valid");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userRessetPasswordModel.UserId);

            if(user == null)
            {
                ModelState.AddModelError("", "User  not fount");
                return View();
            }

            var codeDecodedBytes = WebEncoders.Base64UrlDecode(userRessetPasswordModel.Token);
            var codeDecoded = Encoding.UTF8.GetString(codeDecodedBytes);

            var result = await _userManager.ResetPasswordAsync(user, codeDecoded, userRessetPasswordModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(userRessetPasswordModel);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}