using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZoomZone.Migrations
{
    public partial class AllProductDownoland : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Iphone" },
                    { 12, "HTC" },
                    { 13, "Lenova" },
                    { 14, "Samsung" },
                    { 15, "MacBook" },
                    { 16, "Dell" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Phone" },
                    { 12, "Tablet" },
                    { 13, "NoteBook" }
                });

            migrationBuilder.InsertData(
                table: "CatBraPivots",
                columns: new[] { "Id", "BrandId", "CategoryId" },
                values: new object[,]
                {
                    { 11, 11, 11 },
                    { 12, 12, 11 },
                    { 13, 13, 12 },
                    { 14, 14, 12 },
                    { 15, 15, 13 },
                    { 16, 16, 13 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Batary", "Camera", "CatBraPivotId", "DateTime", "DisplaySize", "Ghz", "Memory", "Name", "OS", "Price", "Processor", "ProductionDate", "RAM", "VideoCart" },
                values: new object[,]
                {
                    { 11, "3000", "12 x 12 x 12", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 inch", "2.3", "128 Gb", "11 Pro", "ISO 13", 2300m, "A9", "17.02.2019", "4 Gb", null },
                    { 12, "2400", "12 x 12", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.8 inch", "2.0", "64 Gb", "X", "ISO 12", 1800m, "A8", "20.02.2018", "3 Gb", null },
                    { 13, "3300", "16 UPx", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.3 inch", "2.5", "128 Gb", "U11", "Androit 8.6", 850m, "Snapdragon 890", "17.02.2015", "6 Gb", null },
                    { 14, "3100", "20 MPx", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.7 inch", "2.2", "64 Gb", "M10", "Androit 7.1", 600m, "Snapdragon 820", "17.02.2014", "4 Gb", null },
                    { 15, "2800", "16 MPx", 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.7 inch", "1.3", "8 Gb", "Tab 2 A7", "Androit 4.4", 400m, "MediaTek", "17.02.2012", "1 Gb", null },
                    { 16, "3400", "20 MPx", 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.0 inch", "2.0", "34 Gb", "Tab A10", "Androit 4.7", 700m, "MediaTek", "17.02.2011", "3 Gb", null },
                    { 17, "2400", "10 MPx", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 inch", "1.8", "32 Gb", "Tab A", "Androit 5", 350m, "quad-core", "17.02.2013", "2 Gb", null },
                    { 18, "7800", "13 MPx", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.5 inch", "1.7", "64 Gb", "TTab S5e", "Androit 9", 400m, "Qualcomm Snapdragon 670", "17.02.2017", "4 Gb", null },
                    { 19, "12800", "10 MPx", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 inch", "3.8", "1 SSD", "Pro", "Macos Catalina 10.15", 5000m, "Inetl 9", "17.02.2019", "16 Gb", "4 Gb" },
                    { 20, "8800", "8 MPx", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15.6 inch", "2.8", "500 Gb", "g3-3590", "Windows 10", 1560m, "Intel 7", "17.02.2016", "8 Gb", "2 GB" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 11, "1.jpg", 11 },
                    { 12, "2.jpg", 12 },
                    { 13, "3.jpg", 13 },
                    { 14, "4.jpg", 14 },
                    { 15, "5.jpg", 15 },
                    { 16, "6.jpg", 16 },
                    { 17, "7.jpg", 17 },
                    { 18, "1.jpg", 18 },
                    { 19, "2.jpg", 19 },
                    { 20, "3.jpg", 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CatBraPivots",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Iphone" },
                    { 2, "HTC" },
                    { 3, "Lenova" },
                    { 4, "Samsung" },
                    { 5, "MacBook" },
                    { 6, "Dell" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Phone" },
                    { 2, "Tablet" },
                    { 3, "NoteBook" }
                });

            migrationBuilder.InsertData(
                table: "CatBraPivots",
                columns: new[] { "Id", "BrandId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 3 },
                    { 6, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Batary", "Camera", "CatBraPivotId", "DateTime", "DisplaySize", "Ghz", "Memory", "Name", "OS", "Price", "Processor", "ProductionDate", "RAM", "VideoCart" },
                values: new object[,]
                {
                    { 1, "3000", "12 x 12 x 12", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 inch", "2.3", "128 Gb", "11 Pro", "ISO 13", 2300m, "A9", "17.02.2019", "4 Gb", null },
                    { 2, "2400", "12 x 12", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.8 inch", "2.0", "64 Gb", "X", "ISO 12", 1800m, "A8", "20.02.2018", "3 Gb", null },
                    { 3, "3300", "16 UPx", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6.3 inch", "2.5", "128 Gb", "U11", "Androit 8.6", 850m, "Snapdragon 890", "17.02.2015", "6 Gb", null },
                    { 4, "3100", "20 MPx", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5.7 inch", "2.2", "64 Gb", "M10", "Androit 7.1", 600m, "Snapdragon 820", "17.02.2014", "4 Gb", null },
                    { 5, "2800", "16 MPx", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7.7 inch", "1.3", "8 Gb", "Tab 2 A7", "Androit 4.4", 400m, "MediaTek", "17.02.2012", "1 Gb", null },
                    { 6, "3400", "20 MPx", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8.0 inch", "2.0", "34 Gb", "Tab A10", "Androit 4.7", 700m, "MediaTek", "17.02.2011", "3 Gb", null },
                    { 7, "2400", "10 MPx", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 inch", "1.8", "32 Gb", "Tab A", "Androit 5", 350m, "quad-core", "17.02.2013", "2 Gb", null },
                    { 8, "7800", "13 MPx", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10.5 inch", "1.7", "64 Gb", "TTab S5e", "Androit 9", 400m, "Qualcomm Snapdragon 670", "17.02.2017", "4 Gb", null },
                    { 9, "12800", "10 MPx", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15 inch", "3.8", "1 SSD", "Pro", "Macos Catalina 10.15", 5000m, "Inetl 9", "17.02.2019", "16 Gb", "4 Gb" },
                    { 10, "8800", "8 MPx", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15.6 inch", "2.8", "500 Gb", "g3-3590", "Windows 10", 1560m, "Intel 7", "17.02.2016", "8 Gb", "2 GB" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 1, "1.jpg", 1 },
                    { 2, "2.jpg", 2 },
                    { 3, "3.jpg", 3 },
                    { 4, "4.jpg", 4 },
                    { 5, "5.jpg", 5 },
                    { 6, "6.jpg", 6 },
                    { 7, "7.jpg", 7 },
                    { 8, "1.jpg", 8 },
                    { 9, "2.jpg", 9 },
                    { 10, "3.jpg", 10 }
                });
        }
    }
}
