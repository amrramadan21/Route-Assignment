using DomainLayer.Contracts;
using DomainLayer.Models;
using PersistenceLayer.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext _dbContext;
        private readonly Dictionary<string, object> _repositories;

        public UnitOfWork(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new Dictionary<string, object>();
        }

        public IGenericRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>
        {
            var typeName = typeof(TEntity).Name;

            // If repository does NOT exist, create it
            if (!_repositories.ContainsKey(typeName))
            {
                var repo = new GenericRepository<TEntity, TKey>(_dbContext);
                _repositories.Add(typeName, repo);
            }

            // Return existing repo
            return (IGenericRepository<TEntity, TKey>)_repositories[typeName];
        }

        public async Task<int> SavaChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
