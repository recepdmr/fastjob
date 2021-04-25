using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V2
{
    [ApiVersion("2.0")]
    public class JobsController : V1.JobsController
    {
        public JobsController(IMediator mediator) : base(mediator)
        {
        }
    }
}
