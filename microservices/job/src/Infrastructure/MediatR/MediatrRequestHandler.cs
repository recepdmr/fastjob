using Ardalis.Result;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.MediatR
{
    public abstract class MediatrRequestHandler<TRequest> : IRequestHandler<TRequest, IResult>, IDisposable
        where TRequest : IRequest<IResult>
    {
        private bool _isDisposed;


        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        public async Task<IResult> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return await HandleAsync(request, cancellationToken);
        }


        protected abstract ValueTask<IResult> HandleAsync(TRequest request, CancellationToken cancellationToken);

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) return;

            _isDisposed = true;
        }

        ~MediatrRequestHandler()
        {
            Dispose(false);
        }
    }

}
