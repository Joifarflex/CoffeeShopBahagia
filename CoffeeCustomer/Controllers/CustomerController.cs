using AutoMapper;
using CoffeeCustomer.Data;
using CoffeeCustomer.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCustomer.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ResponseDto _response;
        private IMapper _mapper;
        private readonly AppDbContext _db;
        private ICouponService _couponService;

        public CustomerController(AppDbContext db, IMapper mapper, ICouponService couponService)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
            _couponService = couponService;
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();

                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList); ;

            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }
    }
}
