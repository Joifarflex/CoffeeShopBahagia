using CoffeeShopWeb.Models;
using CoffeeShopWeb.Services.IServices;
using CoffeeShopWeb.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;

        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.POST,
                Data = productDto,
                Url = StaticDetail.ProductAPIBase + "/api/product/" + productDto
            });
        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.DELETE,
                Url = StaticDetail.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.GET,
                Url = StaticDetail.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> GetProductAsync(string productCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.GET,
                Url = StaticDetail.ProductAPIBase + "/api/product/GetByCode/" + productCode
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.GET,
                Url = StaticDetail.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> UpdateProductsAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetail.ApiType.PUT,
                Data = productDto,
                Url = StaticDetail.ProductAPIBase + "/api/product",
                ContentType = StaticDetail.ContentType.MultipartFormData
            });
        }
    }
}
