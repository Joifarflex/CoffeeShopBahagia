using AutoMapper;
using CoffeeProduct.Models;
using CoffeeProduct.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeProduct
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConf = new MapperConfiguration(conf =>
            {
                conf.CreateMap<ProductDto, Product>();
                conf.CreateMap<Product, ProductDto>();
            });

            return mappingConf;
        }
    }
}
