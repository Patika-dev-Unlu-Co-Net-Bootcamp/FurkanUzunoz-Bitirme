using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.Business.Unitofwork;
using UnluCo.Bitirme.DataAcces.Dtoes;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        public UserController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] UsersDto model)
        {
            try
            {
               var result =await _unit.Users.Create(model);
                await _unit.complete();
                return StatusCode(result.StatusCode, result.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "hata");
                
            }
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] IDPass model)
        {
            try
            {
                var result = await _unit.Users.GetByMail(model) ;
                await _unit.complete();

                return StatusCode(result.statuscode, result.token);
            }
            catch (Exception)
            {


                return BadRequest("direk hata");
            }
        }
    }
}
