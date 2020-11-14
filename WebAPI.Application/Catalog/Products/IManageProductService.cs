﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.ViewModels.Catalog.Products;
using WebAPI.ViewModels.Common;

namespace WebAPI.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(string idProduct);

        Task<bool> UpdatePrice(int idProduct, decimal newPrice);

        Task AddViewcount(int idProduct);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(string idProduct, List<IFormFile> files);

        Task<int> RemoveImages(int  imageId);

        Task<int> UpdateImage(int imageId,string caption,bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
