using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.MongoDB
{
    public class MongoDbRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity
    {

        public MongoDbRepositoryBase(IOptions<MongoDbOptions> options)
        {
            MongoDbOptions = options.Value;

            var client = new MongoClient(MongoDbOptions.ConnectionString);
            var db = client.GetDatabase(MongoDbOptions.Database);
            Collection = db.GetCollection<TEntity>(typeof(TEntity).Name.ToLowerInvariant());
        }

        protected IMongoCollection<TEntity> Collection { get; }
        public MongoDbOptions MongoDbOptions { get; }

        public async ValueTask<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            var options = new InsertOneOptions { BypassDocumentValidation = false };
            await Collection.InsertOneAsync(entity, options, cancellationToken);
            return entity;
        }

        public async ValueTask<bool> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            var options = new BulkWriteOptions { IsOrdered = false, BypassDocumentValidation = false };
            return (await Collection.BulkWriteAsync((IEnumerable<WriteModel<TEntity>>)entities, options, cancellationToken)).IsAcknowledged;
        }

        public async ValueTask<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            return await Collection.FindOneAndDeleteAsync(x => x.Id == entity.Id, cancellationToken: cancellationToken);
        }

        public async ValueTask<TEntity> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return await Collection.FindOneAndDeleteAsync(x => x.Id == id, cancellationToken: cancellationToken);
        }

        public async ValueTask<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate = null, CancellationToken cancellationToken = default)
        {
            if (predicate != null)
                return await Collection.Find(predicate).ToListAsync(cancellationToken);
            else
                return await Collection.Find(x => true).ToListAsync(cancellationToken);

        }

        public async ValueTask<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            return await Collection.FindOneAndReplaceAsync(x => x.Id == entity.Id, entity, cancellationToken: cancellationToken);
        }
    }
}
