using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Entities;

namespace WebAPI.Data.EF
{
    public class WebApiDbContext:DbContext
    {
        public WebApiDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<ordersDetails> ordersDetails { get; set; }

        public DbSet<ordersList> ordersLists { get; set; }
        public DbSet<productBrand> productBrands { get; set; }

        public DbSet<productCategories> productCategories { get; set; }

        public DbSet<productColor> productColors { get; set; }
        public DbSet<productDetail> productDetails { get; set; }
        public DbSet<productPhotos> productPhotos { get; set; }
        public DbSet<products> products { get; set; }
        public DbSet<productSize> ProductSizes { get; set; }

        public DbSet<productTypes> productTypes { get; set; }
        public DbSet<rating> ratings { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<vouchers> vouchers { get; set; }



    }
}
