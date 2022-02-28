using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Unitofwork;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public CategoryController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet("getAllCategories")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok( await _unit.Category.GetAllCategories());
            }
            catch (Exception)
            {

               return BadRequest("Hata meydana geldi.");
            }
            
            
        }
        [HttpGet]
        public async  Task<IActionResult> GetAllFromProduct()
        {
            try
            {
                var result = await _unit.Product.GetAll();
                return Ok(result);
            }
            catch (Exception)
            {
               return BadRequest("hata oldu.");
            }
           
        }
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductsById(int id)
        {
            try
            {
                var result=await _unit.Category.GetProductsUsingCategoryid(id);
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("hata meydana geldi.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            var result = await _unit.Category.CreateCategory(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Category model)
        {
            var result =await _unit.Category.UpdateCategory(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
