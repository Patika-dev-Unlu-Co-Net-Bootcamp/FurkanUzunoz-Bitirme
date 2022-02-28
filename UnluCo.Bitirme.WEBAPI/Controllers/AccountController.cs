using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Unitofwork;

namespace UnluCo.Bitirme.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public AccountController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet("GetMyOffers")]
        public async Task<IActionResult> GetMyOffers(int id)
        {
            var result =await _unit.Account.getMyOffers(id);
            return Ok(result);
            
        }
        [HttpGet("GetOffersByProduct")]
        public async Task<IActionResult> GetOffersByProduct(int id)
        {
            var result = await _unit.Account.getOffersByMyProduct(id);
            return Ok(result);

        }
        [HttpGet("AcceptOrNot")]
        public async Task<IActionResult> AcceptOrNot(int OfferID,bool accept)
        {
            var result = await _unit.Account.OkOrNot(OfferID,accept);
            await _unit.complete();
            return Ok(result);

        }
    }
}
