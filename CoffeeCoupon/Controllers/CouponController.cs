using AutoMapper;
using CoffeeCoupon.Data;
using CoffeeCoupon.Models;
using CoffeeCoupon.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeCoupon.Controllers
{
    [Route("api/coupon")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private readonly IMapper _mapper;

        public CouponController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();

                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList); ;

            }
            catch(Exception e){

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }

        //Cek Per Kupon
        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Coupon getCoupon = _db.Coupons.Where(c => c.Id == id).FirstOrDefault();
                
                _response.Result = _mapper.Map<CouponDto>(getCoupon); ;
            }
            catch(Exception e){

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon getCouponCode = _db.Coupons.FirstOrDefault(c => c.CouponCode.ToLower() == code.ToLower());
                if (getCouponCode == null)
                {
                    _response.IsSuccess = false;
                }
                _response.Result = _mapper.Map<CouponDto>(getCouponCode); ;
            }
            catch (Exception e){

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CouponDto>(obj);

            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CouponDto>(obj);

            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }


        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(c => c.Id == id);
                _db.Coupons.Remove(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CouponDto>(obj);

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
