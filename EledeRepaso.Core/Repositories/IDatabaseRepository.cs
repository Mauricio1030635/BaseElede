using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Core.Repositories
{
    public interface IDatabaseRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class
    {

        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity>  ExecWithStoreProcedure(string query, params object[] parameters);

    }
}
