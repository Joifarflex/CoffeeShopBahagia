using AutoMapper;
using CoffeeProduct.Data;
using CoffeeProduct.Models;
using CoffeeProduct.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeProduct.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private readonly IMapper _mapper;

        public ProductController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Product> objList = _db.Products.ToList();

                _response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList); ;

            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Product getProduct = _db.Products.Where(c => c.Id == id).FirstOrDefault();

                _response.Result = _mapper.Map<ProductDto>(getProduct); ;
            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }

        //[HttpGet]
        //[Route("GetByName/{name}")]
        //public ResponseDto GetByCode(string name)
        //{
        //    try
        //    {
        //        Product getProductName = _db.Products.FirstOrDefault(c => c.ProductName.ToLower() == name.ToLower());
        //        if (getProductName == null)
        //        {
        //            _response.IsSuccess = false;
        //        }
        //        _response.Result = _mapper.Map<ProductDto>(getProductName); ;
        //    }
        //    catch (Exception e)
        //    {

        //        _response.IsSuccess = false;
        //        _response.Message = e.Message;
        //    }

        //    return _response;
        //}

        [HttpPost]
        public ResponseDto Post([FromBody] ProductDto ProductDto)
        {
            try
            {
                Product obj = _mapper.Map<Product>(ProductDto);
                _db.Products.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(obj);

            }
            catch (Exception e)
            {

                _response.IsSuccess = false;
                _response.Message = e.Message;
            }

            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] ProductDto ProductDto)
        {
            try
            {
                Product obj = _mapper.Map<Product>(ProductDto);
                _db.Products.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(obj);

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
                Product obj = _db.Products.First(c => c.Id == id);
                _db.Products.Remove(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ProductDto>(obj);

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
