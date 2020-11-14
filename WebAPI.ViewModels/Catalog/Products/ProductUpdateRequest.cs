using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public string Id { get; set; }
        public decimal price { get; set; }

        public decimal salePrice { get; set; }
        public string detail { get; set; }

        public string ProductName { get; set; }

        public string idSize { get; set; }
        public string idBrand { get; set; }
        public string idColor { get; set; }
        public string idCategory { get; set; }
        public string idType { get; set; }
    }
}

