using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Unitofwork;
using UnluCo.Bitirme.DataAcces.Dtoes;

namespace UnluCo.Bitirme.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet("GetMyProduct")]
        public async Task<IActionResult> getProd(int id)
        {
            try
            {
                return Ok(await _unit.Product.GetProductsFromMein(id));
            }
            catch (Exception)
            {

                return BadRequest("hata oldu.");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> delete(int ProductID) 
        {
            var result = await _unit.Product.Delete(ProductID);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductDto model)
        {
            var result = await _unit.Product.Create(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
