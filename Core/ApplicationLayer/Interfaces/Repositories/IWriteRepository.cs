using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(T entities);
        Task<T> UpdateAsync(T entity);
        Task SoftDeleteAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteAsyncRange(IList<T> entity);
    }
}
