using Ardalis.SmartEnum;

namespace Core.Domain.Entities
{
    public sealed class JobStatus : SmartEnum<JobStatus>
    {
        public JobStatus(string name, int value) : base(name, value)
        {
        }

        public static readonly JobStatus WatingApprove = new(nameof(WatingApprove), 1);
    }
}
