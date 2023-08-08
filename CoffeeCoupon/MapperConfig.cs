using AutoMapper;
using CoffeeCoupon.Models;
using CoffeeCoupon.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCoupon
{
    public class MapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConf = new MapperConfiguration(conf =>
            {
                conf.CreateMap<CouponDto, Coupon>();
                conf.CreateMap<Coupon, CouponDto>();
            });

            return mappingConf;
        }
    }
}
