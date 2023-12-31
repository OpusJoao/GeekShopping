﻿using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindById(long id);

        Task<ProductModel> Create(ProductModel product);

        Task<ProductModel> Update(ProductModel product);

        Task<bool> DeleteById(long id);
    }
}
