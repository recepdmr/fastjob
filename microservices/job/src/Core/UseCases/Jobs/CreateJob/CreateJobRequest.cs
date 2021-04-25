using Core.Domain.Entities;
using Infrastructure.MediatR;

namespace Core.UseCases.Jobs.CreateJob
{
   public class CreateJobRequest : ResultRequest
    {
        public Job Job { get; set; }
    }
}
