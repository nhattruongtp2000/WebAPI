using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.EF;
using WebAPI.ViewModels.Catalog.Products;
using WebAPI.ViewModels.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {

        private readonly WebApiDbContext _context;
        public PublicProductService(WebApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.products
                        join pt in _context.productDetails on p.idProduct equals pt.idProduct
                        join pic in _context.ProductInCategories on p.idProduct equals pic.idProduct
                        join c in _context.productCategories on pic.idCategory equals c.idCategory
                        select new { p, pt, pic };

            var data = await query.Select(x=>new ProductViewModel()
                {
                    Id = x.p.idProduct,
                    ProductName = x.pt.ProductName,
                    price = x.pt.price,
                    salePrice = x.pt.salePrice,
                    ViewCount = x.p.ViewCount,
                    detail = x.pt.detail,
                    dateAdded=x.pt.dateAdded

                }).ToListAsync();
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            var query = from p in _context.products
                        join pt in _context.productDetails on p.idProduct equals pt.idProduct
                        join pic in _context.ProductInCategories on p.idProduct equals pic.idProduct
                        join c in _context.productCategories on pic.idCategory equals c.idCategory
                        select new { p, pt, pic };
            //2. filter
            if (request.idCategory.HasValue&& request.idCategory.Value>0)
                query = query.Where(p=>p.pic.idCategory==request.idCategory);

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id =x.p.idProduct,
                    ProductName = x.pt.ProductName,
                    price = x.pt.price,
                    salePrice = x.pt.salePrice,
                    ViewCount = x.p.ViewCount,
                    detail = x.pt.detail,

                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResult;
        }
    }
}
