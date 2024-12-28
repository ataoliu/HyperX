
using HyperX.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace HyperX.Repository;

// public interface IRepository<T> : EfCoreRepository<HyperXDbContext, T>, IRepository<T> where T : Entity{

// }
public interface IGenericRepository<TEntity, TKey> : IRepository<TEntity, TKey>where TEntity : class, IEntity<TKey>
    {
        Task<List<TEntity>> GetPagedListAsync(int skipCount, int maxResultCount);
        Task<TEntity> GetWithDetailsAsync(TKey id);
    }
// public interface IRepository<T> where T : Entity{

// }
