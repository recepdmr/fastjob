using Microsoft.AspNetCore.Mvc;

namespace Api.Abstraction.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FastJobJobsControllerBase : ControllerBase
    {
    }
}
