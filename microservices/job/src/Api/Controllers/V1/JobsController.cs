using Api.Abstraction.Controllers;
using Ardalis.Result;
using Core.UseCases.Jobs.CreateJob;
using Core.UseCases.Jobs.GetAllJobs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers.V1
{
    public class JobsController : V1ControllerBase
    {
        public JobsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public virtual async ValueTask<IResult> Get([FromQuery] GetAllJobsRequest request, CancellationToken cancellationToken)
        {
            return await Mediator.Send(request, cancellationToken);
        }


        [HttpPost]
        public async ValueTask<IResult> Post([FromBody] CreateJobRequest request, CancellationToken cancellationToken)
        {
            return await Mediator.Send(request, cancellationToken);
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
