using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using ZoomZone.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ZoomZone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using ZoomZone.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ZoomZone
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(10);
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = false;
                options.Cookie.Name = "MyAppSession";
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = (context) => true;
            });

            services.ConfigureApplicationCookie(options=>
            {
                options.AccessDeniedPath = "/Admin/Account/Login";
                options.LoginPath = "/Admin/Account/Login";
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
               .AddCookie(options =>
               {
                   options.Cookie.HttpOnly = true;
                   options.Cookie.IsEssential = true;
                   options.Cookie.MaxAge = TimeSpan.FromMinutes(25);

               });

            services.Configure<CookieOptions>(options =>
            {
                options.HttpOnly = true;
                options.IsEssential = true;
                options.MaxAge = TimeSpan.FromDays(1);
            });


            services.AddIdentity<AppUser, IdentityRole>(options =>
             {
                 // Password security. Part
                 options.Password.RequiredLength = 8;
                 options.Password.RequireDigit = true;
                 options.Password.RequireLowercase = true;
                 options.Password.RequiredUniqueChars = 5;
                 options.Password.RequireNonAlphanumeric = true;
                 options.Password.RequireUppercase = true;

                 //Lockout 
                 options.Lockout.MaxFailedAccessAttempts = 4;
                 options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                 options.Lockout.AllowedForNewUsers = false;

                 //User info
                 options.User.RequireUniqueEmail = true;
                 options.User.AllowedUserNameCharacters =
                 "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@"; ;
             })
                .AddEntityFrameworkStores<ZZContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

           
            services.AddSingleton<IEmailSender, EmailSender>(e => new EmailSender(
                _configuration["EmailSettings:Host"],
                _configuration.GetValue<int>("EmailSettings:Port"),
                _configuration.GetValue<bool>("EmailSettings:SSL"),
                _configuration["EmailSettings:Username"],
                _configuration["EmailSettings:Password"]

                ));

            services.AddMvc()

            .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services.AddDbContext<ZZContext>(options =>
            {
                options.UseSqlServer(_configuration["ConnectionStrings:Default"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();

            app.UseMvc(router =>
            {
                router.MapRoute(
                name: "areas",
                template: "{area:exists}/{controller=Dasboard}/{action=Index}/{id?}"
              );
                router.MapRoute(
                    name: "default",
                    template:"{controller=Home}/{action=Index}/{id?}"
                    );

            });

        }
    }
}
