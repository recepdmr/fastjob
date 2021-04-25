using System;

namespace Infrastructure.DataAccess
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
