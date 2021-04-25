using Infrastructure.MediatR;

namespace Core.UseCases.Jobs.GetAllJobs
{
    public class GetAllJobsRequest : ResultRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
