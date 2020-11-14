using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.EF;
using WebAPI.Data.Entities;
using WebAPI.Utilities.Exceptions;
using WebAPI.ViewModels.Catalog.Products;
using WebAPI.ViewModels.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebAPI.Application.Common;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;

namespace WebAPI.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly WebApiDbContext _context;
        private readonly IStorageService _storageService;
        public ManageProductService(WebApiDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> AddImage(string idProduct, List<IFormFile> files)
        {
            throw new NotImplementedException();
        }

        public async Task AddViewcount(int idProduct)
        {
            var product = await _context.products.FindAsync(idProduct);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }
      

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new products()
            {
                idSize = request.idSize,
                idBrand = request.idBrand,
                idCategory = request.idCategory,
                idColor = request.idColor,
                idType = request.idType,
                ViewCount = 0,
                productDetails = new List<productDetail>()
                {
                     new productDetail()
                     {
                         ProductName=request.ProductName,
                         price=request.price,
                         salePrice=request.salePrice,
                         detail=request.detail,
                         dateAdded=DateTime.Now,
                     }
                }
            };

            //Save image
            if (request.ThumbnailImage != null)
            {
                product.productPhotos = new List<productPhotos>()
                {
                    new productPhotos()
                    {
                        Caption = "Thumbnail image",
                        uploadedTime = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        
                    }
                };
            }
            _context.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(string idProduct)
        {
            var product = await _context.products.FindAsync(idProduct);
            if (product == null) throw new WebAPIException($"Cannot find a product: {idProduct}");

            var images = _context.productPhotos.Where(i => i.idProduct == idProduct);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }


            _context.products.Remove(product);
            return await _context.SaveChangesAsync();
        }

      

        public  async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.products
                        join pt in _context.productDetails on p.idProduct equals pt.idProduct
                        join pic in _context.ProductInCategories on p.idProduct equals pic.idProduct
                        join c in _context.productCategories on pic.idCategory equals c.idCategory
                        select new { p, pt, pic };
            //2. filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.ProductName.Contains(request.Keyword));

            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(p => request.CategoryIds.Contains(p.pic.idCategory));
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.idProduct,
                    ProductName = x.pt.ProductName,
                    price = x.pt.price,
                    salePrice = x.pt.salePrice,
                    ViewCount = x.p.ViewCount,
                    detail=x.pt.detail,
                    
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };
            return pagedResult;
        }

        public Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImages(int imageId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.products.FindAsync(request.Id);
            var productDetails = await _context.productDetails.FirstOrDefaultAsync(x => x.idProduct == request.Id);

            if (product == null || productDetails == null) throw new WebAPIException($"Cannot find a product with id: {request.Id}");

            productDetails.ProductName = request.ProductName;
            productDetails.price = request.price;
            productDetails.detail = request.detail;

            //Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.productPhotos.FirstOrDefaultAsync(i => i.IsDefault == true && i.idProduct == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.productPhotos.Update(thumbnailImage);
                }
            }


            return await _context.SaveChangesAsync();
        }

        public Task<int> UpdateImage(int imageId, string caption, bool isDefault)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdatePrice(int idProduct, decimal newPrice)
        {
            var product = await _context.productDetails.FindAsync(idProduct);
            if (product == null) throw new WebAPIException($"Cannot find a product with id: {idProduct}");
            product.price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
