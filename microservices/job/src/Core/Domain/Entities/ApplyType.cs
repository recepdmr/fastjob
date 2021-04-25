using Ardalis.SmartEnum;

namespace Core.Domain.Entities
{
    public sealed class ApplyType : SmartEnum<ApplyType>
    {
        public ApplyType(string name, int value) : base(name, value)
        {
        }

        public static readonly ApplyType WithEmail = new(nameof(WithEmail), 1);
        public static readonly ApplyType WithUrl = new(nameof(WithUrl), 1);
    }
}
