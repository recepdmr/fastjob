using Ardalis.Result;
using Core.Domain.Entities;
using Infrastructure.DataAccess;
using Infrastructure.MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Core.UseCases.Jobs.CreateJob
{
    class CreateJobRequestHandler : MediatrRequestHandler<CreateJobRequest>
    {
        public CreateJobRequestHandler(IRepository<Job> jobRepository)
        {
            JobRepository = jobRepository;
        }

        public IRepository<Job> JobRepository { get; }

        protected override async ValueTask<IResult> HandleAsync(CreateJobRequest request, CancellationToken cancellationToken)
        {
            return Result<Job>.Success(await JobRepository.AddAsync(request.Job, cancellationToken));
        }
    }
}
