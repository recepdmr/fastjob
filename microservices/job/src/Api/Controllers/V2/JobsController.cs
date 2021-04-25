using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V2
{
    [ApiVersion("2.0")]
    public class JobsController : V1.JobsController
    {
        [HttpGet]
        public override IActionResult Get()
        {
            return Ok("v2");
        }
    }
}
