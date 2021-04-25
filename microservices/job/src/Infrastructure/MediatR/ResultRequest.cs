using Ardalis.Result;
using MediatR;

namespace Infrastructure.MediatR
{
    public abstract class ResultRequest : IRequest<IResult>
    {
    }
}
