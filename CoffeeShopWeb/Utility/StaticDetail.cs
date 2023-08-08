using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWeb.Utility
{
    public class StaticDetail
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public enum ContentType
        {
            Json,
            MultipartFormData,
        }

        public static string CouponAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
    }
}
