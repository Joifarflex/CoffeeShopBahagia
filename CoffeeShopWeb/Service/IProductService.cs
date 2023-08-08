using CoffeeShopWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb.Service
{
    public interface IProductService
    {
        Task<ResponseDto?> GetProductAsync(string ProductCode);
        Task<ResponseDto?> GetAllProductAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductAsync(ProductDto productDto);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto productDto);

        Task<ResponseDto?> DeleteProductAsync(int id);


    }
}
