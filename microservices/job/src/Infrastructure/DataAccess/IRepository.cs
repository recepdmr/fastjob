using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public interface IRepository<T> where T : Entity
    {
        ValueTask<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, CancellationToken cancellationToken = default);
        ValueTask<T> AddAsync(T entity, CancellationToken cancellationToken);
        ValueTask<bool> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        ValueTask<T> UpdateAsync(T entity, CancellationToken cancellationToken);
        ValueTask<T> DeleteAsync(T entity, CancellationToken cancellationToken);
    }
}
