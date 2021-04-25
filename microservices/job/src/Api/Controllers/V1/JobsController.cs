using Api.Abstraction.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers.V1
{
    public class JobsController : V1ControllerBase
    {

        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok("v1");
        }

        [Authorize]
        [HttpGet("auth")]
        public virtual IActionResult GetAuth()
        {
            return Ok("v1");
        }

        [HttpGet("dsad")]
        [Obsolete("Artık Kullanılmıyor")]
        public IActionResult Get2()
        {
            return Ok("v1");
        }
    }
}
