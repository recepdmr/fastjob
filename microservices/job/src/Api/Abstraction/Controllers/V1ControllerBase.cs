using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Abstraction.Controllers
{
    [ApiVersion("1.0")]
    public abstract class V1ControllerBase : FastJobJobsControllerBase
    {
        protected V1ControllerBase(IMediator mediator) : base(mediator)
        {
        }
    }
}
