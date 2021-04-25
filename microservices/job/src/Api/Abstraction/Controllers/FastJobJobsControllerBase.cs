using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Abstraction.Controllers
{
    [ApiController]
    [TranslateResultToActionResult]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class FastJobJobsControllerBase : ControllerBase
    {
        protected FastJobJobsControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected IMediator Mediator { get; }
    }
}
