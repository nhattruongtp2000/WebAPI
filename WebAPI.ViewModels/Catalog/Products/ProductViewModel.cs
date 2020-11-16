using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public decimal price { get; set; }
        public string ProductName { get; set; }
        public decimal salePrice { get; set; }
        public string detail { get; set; }
        public int ViewCount { get; set; }
        public DateTime dateAdded { get; set; }


    }
}
