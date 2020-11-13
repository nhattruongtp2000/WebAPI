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
                new productDetail() { idProductDetail="1",price=1000000,salePrice=1000000,photoReview="yes",detail="goood product",isSaling=Status.Active,dateAdded=new DateTime(2019,10,21)},
                new productDetail() { idProductDetail = "2", price = 2000000, salePrice = 1000000, photoReview = "yes", detail = "goood product", isSaling = Status.UnActive, expiredSalingDate=new DateTime(2020,10,12), dateAdded = new DateTime(2019, 10, 21) }
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
                new productCategories() { idCategory="1",categoryName="Shoes"},
                new productCategories() { idCategory = "2", categoryName = "Shirt" }
            );
            modelBuilder.Entity<productTypes>().HasData(
                new productTypes() { idType="1",typeName="Cheap"},
                new productTypes() { idType = "2", typeName = "Expensive" }
            );
            modelBuilder.Entity<products>().HasData(
                new products() { idProduct = "001", idProductDetail = "1", idSize = "1", idBrand = "1", idColor = "ffffff", idCategory = "1", idType = "1" }

                ) ;
        }
    }
}
