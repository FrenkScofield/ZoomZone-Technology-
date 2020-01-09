using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZoomZone.Models;

namespace ZoomZone.DAL
{
    public class ZZContext : IdentityDbContext<AppUser>
    {
        public ZZContext(DbContextOptions<ZZContext>options): base(options)
        {
        }

        public DbSet<SliderHome> SliderHomes { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CatBraPivot> CatBraPivots { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProColPivot> ProColPivots { get; set; }
        public DbSet<About> Abouts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SliderHome>().HasData(
                new SliderHome { Id = 1, SImage = "slider4.jpg" },
                  new SliderHome { Id = 2, SImage = "slider5.jpg" },
                    new SliderHome { Id = 3, SImage = "slider7.jpg" }
                );
            modelBuilder.Entity<Advertising>().HasData(
               new Advertising { Id=1, Title="AngellaWhite" , Image= "banner20.jpg" },
               new Advertising { Id=2, Title="LisaaAnn" ,Image= "banner24.jpg" }
                
                );
            modelBuilder.Entity<Category>().HasData(
                new Category {Id=11, Name="Phone" },
                new Category { Id=12,Name="Tablet"},
                new Category { Id=13,Name="NoteBook"}
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id=11,Name="Iphone"},
                new Brand { Id=12,Name="HTC"},
                new Brand { Id=13,Name="Lenova"},
                new Brand { Id=14,Name="Samsung"},
                new Brand { Id=15,Name="MacBook"},
                new Brand { Id=16,Name="Dell"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 11, CatBraPivotId = 11 ,Name = "11 Pro", Memory = "128 Gb", DisplaySize = "6 inch", RAM = "4 Gb", Ghz = "2.3", Camera = "12 x 12 x 12", Batary = "3000", Price = 2300, OS = "ISO 13", Processor = "A9", ProductionDate = "17.02.2019",Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount=10},
                new Product { Id = 12, CatBraPivotId = 11, Name = "X", Memory = "64 Gb", DisplaySize = "5.8 inch", RAM = "3 Gb", Ghz = "2.0", Camera = "12 x 12", Batary = "2400", Price = 1800, OS = "ISO 12", Processor = "A8", ProductionDate = "20.02.2018", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 12 },
                new Product { Id = 13, CatBraPivotId = 12, Name = "U11", Memory = "128 Gb", DisplaySize = "6.3 inch", RAM = "6 Gb", Ghz = "2.5", Camera = "16 UPx", Batary = "3300", Price = 850, OS = "Androit 8.6", Processor = "Snapdragon 890", ProductionDate = "17.02.2015", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 15 },
                new Product { Id = 14, CatBraPivotId = 12, Name = "M10", Memory = "64 Gb", DisplaySize = "5.7 inch", RAM = "4 Gb", Ghz = "2.2", Camera = "20 MPx", Batary = "3100", Price = 600, OS = "Androit 7.1", Processor = "Snapdragon 820", ProductionDate = "17.02.2014", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 16 },
                new Product { Id = 15, CatBraPivotId = 13, Name = "Tab 2 A7", Memory = "8 Gb", DisplaySize = "7.7 inch", RAM = "1 Gb", Ghz = "1.3", Camera = "16 MPx", Batary = "2800", Price = 400, OS = "Androit 4.4", Processor = "MediaTek", ProductionDate = "17.02.2012", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 17 },
                new Product { Id = 16, CatBraPivotId = 13, Name = "Tab A10", Memory = "34 Gb", DisplaySize = "8.0 inch", RAM = "3 Gb", Ghz = "2.0", Camera = "20 MPx", Batary = "3400", Price = 700, OS = "Androit 4.7", Processor = "MediaTek", ProductionDate = "17.02.2011", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 18 },
                new Product { Id = 17, CatBraPivotId = 14, Name = "Tab A", Memory = "32 Gb", DisplaySize = "7 inch", RAM = "2 Gb", Ghz = "1.8", Camera = "10 MPx", Batary = "2400", Price = 350, OS = "Androit 5", Processor = "quad-core", ProductionDate = "17.02.2013", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 20 },
                new Product { Id = 18, CatBraPivotId = 14,Name = "TTab S5e", Memory = "64 Gb", DisplaySize = "10.5 inch", RAM = "4 Gb", Ghz = "1.7", Camera = "13 MPx", Batary = "7800", Price = 400, OS = "Androit 9", Processor = "Qualcomm Snapdragon 670", ProductionDate = "17.02.2017", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 50 },
                new Product { Id = 19, CatBraPivotId = 15, Name = "Pro", Memory = "1 SSD", DisplaySize = "15 inch", RAM = "16 Gb", Ghz = "3.8", Camera = "10 MPx", Batary = "12800", Price = 5000, OS = "Macos Catalina 10.15", VideoCart = "4 Gb", Processor = "Inetl 9", ProductionDate = "17.02.2019", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 60 },
                new Product { Id = 20, CatBraPivotId = 16, Name = "g3-3590", Memory = "500 Gb", DisplaySize = "15.6 inch", RAM = "8 Gb", Ghz = "2.8", Camera = "8 MPx", Batary = "8800", Price = 1560, OS = "Windows 10", VideoCart = "2 GB", Processor = "Intel 7", ProductionDate = "17.02.2016", Description = "Donec ac tempus ante. Fusce ultricies massa massa. Fusce aliquam, purus eget sagittis vulputate, sapien libero hendrerit est, sed commodo augue nisi non neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor, lorem et placerat vestibulum, metus nisi posuere nisl", Discount = 30 }


                );
            modelBuilder.Entity<CatBraPivot>().HasData(
                
                new CatBraPivot { Id = 11, CategoryId = 11, BrandId = 11 },
                new CatBraPivot { Id = 12, CategoryId = 11, BrandId = 12 },
                new CatBraPivot { Id = 13, CategoryId = 12, BrandId = 13 },
                new CatBraPivot { Id = 14, CategoryId = 12, BrandId = 14 },
                new CatBraPivot { Id = 15, CategoryId = 13, BrandId = 15 },
                new CatBraPivot { Id = 16, CategoryId = 13, BrandId = 16 }

                );

            modelBuilder.Entity<Images>().HasData(
                
                new Images { Id = 11, ImagePath = "1.jpg", ProductId = 11 },
                new Images { Id = 12, ImagePath = "2.jpg", ProductId = 12 },
                new Images { Id = 13, ImagePath = "3.jpg", ProductId = 13 },
                new Images { Id = 14, ImagePath = "4.jpg", ProductId = 14 },
                new Images { Id = 15, ImagePath = "5.jpg", ProductId = 15 },
                new Images { Id = 16, ImagePath = "6.jpg", ProductId = 16 },
                new Images { Id = 17, ImagePath = "7.jpg", ProductId = 17 },
                new Images { Id = 18, ImagePath = "1.jpg", ProductId = 18 },
                new Images { Id = 19, ImagePath = "2.jpg", ProductId = 19 },
                new Images { Id = 20, ImagePath = "3.jpg", ProductId = 20 }

                );
           
            modelBuilder.Entity<Color>().HasData(

                new Color  { Id = 1, Name = "Black" },
                new Color { Id = 2, Name = "White" },
                new Color { Id = 3, Name = "Red" },
                new Color { Id = 4, Name = "green" },
                new Color { Id = 5, Name = "Yellow" },
                new Color { Id = 6, Name = "Purple" },
                new Color { Id = 7, Name = "Brown" }
                );

            modelBuilder.Entity<ProColPivot>().HasData(
                new ProColPivot { Id = 1, ProductId = 11, ColorId = 1 },
                new ProColPivot { Id = 2, ProductId = 11, ColorId = 2 },
                new ProColPivot { Id = 3, ProductId = 12, ColorId = 3 },
                new ProColPivot { Id = 4, ProductId = 12, ColorId = 4 },
                new ProColPivot { Id = 5, ProductId = 13, ColorId = 5 },
                new ProColPivot { Id = 6, ProductId = 13, ColorId = 6 },
                new ProColPivot { Id = 7, ProductId = 14, ColorId = 7 },
                new ProColPivot { Id = 8, ProductId = 14, ColorId = 1 },
                new ProColPivot { Id = 9, ProductId = 15, ColorId = 1 },
                new ProColPivot { Id = 10, ProductId = 15, ColorId = 3 },
                new ProColPivot { Id = 11, ProductId = 16, ColorId = 6 }
                );

       
    }
    }
   
}

