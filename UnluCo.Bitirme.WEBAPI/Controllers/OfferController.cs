using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.Business.Unitofwork;
using UnluCo.Bitirme.DataAcces.Dtoes;

namespace UnluCo.Bitirme.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public OfferController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpPost("giveOffer")]
        public async Task<IActionResult> GiveOffer(OffersDto model)
        {
            var result = await _unit.Offer.GiveOffer(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
        [HttpPost("Buy")]
        public async Task<IActionResult> Buy(OffersDto model)
        {
            var result = await _unit.Offer.Buy(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
        [HttpPut("BackToOffer")]
        public async Task<IActionResult> BackOffer(OffersDto model)
        {
            var result = await _unit.Offer.BackToOffer(model);
            await _unit.complete();
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
