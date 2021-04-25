using Ardalis.SmartEnum;

namespace Core.Domain.Entities
{
    public sealed class Gender : SmartEnum<Gender>
    {
        public Gender(string name, int value) : base(name, value)
        {
        }

        public static readonly Gender Male = new(nameof(Male), 1);
        public static readonly Gender Female = new(nameof(Female), 2);
    }
}
