using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Entities;
using WebAPI.Data.Enums;

namespace WebAPI.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<productDetail>().HasData(
                new productDetail() { idProduct=1,idProductDetail=1,ProductName="Shoe",price=1000000,salePrice=1000000,detail="goood product",isSaling=Status.Active,dateAdded=new DateTime(2019,10,21)},
                new productDetail() { idProduct=2,idProductDetail = 2, ProductName = "Pro" ,price = 2000000, salePrice = 1000000, detail = "goood product", isSaling = Status.UnActive, expiredSalingDate=new DateTime(2020,10,12), dateAdded = new DateTime(2019, 10, 21) }
            );
            modelBuilder.Entity<productSize>().HasData(
                new productSize() { idSize="1",sizeName="L"},
                new productSize() { idSize="2",sizeName="M"}
            );
            modelBuilder.Entity<productBrand>().HasData(
                new productBrand() { idBrand="1",brandName="Logo",brandDetail="Logo"},
                new productBrand() { idBrand = "2", brandName = "Company", brandDetail = "Company" }
            );
            modelBuilder.Entity<productColor>().HasData(
                new productColor() { idColor="ffffff",colorName="While"},
                new productColor() { idColor = "Red", colorName = "Red" }
            );
            modelBuilder.Entity<productCategories>().HasData(
                new productCategories() { idCategory=1,categoryName="Shoes"},
                new productCategories() { idCategory =2, categoryName = "Shirt" }
            );
            modelBuilder.Entity<productTypes>().HasData(
                new productTypes() { idType="1",typeName="Cheap"},
                new productTypes() { idType = "2", typeName = "Expensive" }
            );
            modelBuilder.Entity<products>().HasData(
                new products() { idProduct = 1 ,idSize = "1", idBrand = "1", idColor = "ffffff", idCategory = "1", idType = "1" },
                new products() { idProduct = 2, idSize = "1", idBrand = "1", idColor = "ffffff", idCategory = "1", idType = "1" }
            );


            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<role>().HasData(new role
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<users>();
            modelBuilder.Entity<users>().HasData(new users
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nhattruongtp2000@gmail.com",
                NormalizedEmail = "nhattruongtp2000@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                birthday=new DateTime(2020,10,12),
                firstName = "Nguyen",
                lastName = "Truong",
                lastLogin=new DateTime(2020,11,13)
 
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
