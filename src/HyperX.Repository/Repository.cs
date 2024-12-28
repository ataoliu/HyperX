using HyperX.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HyperX.Repository;

// public class Repository<T> : EfCoreRepository<HyperXDbContext, T>, IRepository<T> where T : Entity
// {
//     public Repository(IDbContextProvider<HyperXDbContext> dbContextProvider) : base(dbContextProvider)
//     {
//     }
// }