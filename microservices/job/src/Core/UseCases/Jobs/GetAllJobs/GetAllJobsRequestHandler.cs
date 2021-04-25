using Ardalis.Result;
using Core.Domain.Entities;
using Infrastructure.DataAccess;
using Infrastructure.MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Core.UseCases.Jobs.GetAllJobs
{
    public class GetAllJobsRequestHandler : MediatrRequestHandler<GetAllJobsRequest>
    {
        public IRepository<Job> JobRepository { get; }

        public GetAllJobsRequestHandler(IRepository<Job> jobRepository)
        {
            JobRepository = jobRepository;
        }
        protected async override ValueTask<IResult> HandleAsync(GetAllJobsRequest request, CancellationToken cancellationToken)
        {
            var jobs = await JobRepository.GetAsync(cancellationToken: cancellationToken);

            return new PagedResult<IReadOnlyList<Job>>(new PagedInfo(0, 1, 1, 1), jobs);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
