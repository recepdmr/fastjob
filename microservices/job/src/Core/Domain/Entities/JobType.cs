using Ardalis.SmartEnum;

namespace Core.Domain.Entities
{
    public sealed class JobType : SmartEnum<JobType>
    {
        public JobType(string name, int value) : base(name, value)
        {
        }

        public static readonly JobType Freelance = new(nameof(Freelance), 1);
        public static readonly JobType Remote = new(nameof(Remote), 1);
    }
}
