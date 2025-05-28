using EledeRepaso.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
    

using Microsoft.EntityFrameworkCore;





namespace EledeRepaso.Core.Implementacion
{



    public abstract class RepositoryBase<TContext, TEntity, TId> : IDatabaseRepository<TEntity, TId> where TEntity : class where TContext : DbContext
    {

        protected TContext Entities { get; }
        protected RepositoryBase(TContext entities)
        {
            this.Entities = entities;
        }        

        public  async Task AddAsync(TEntity entity) => await this.Entities.Set<TEntity>().AddAsync(entity);

        public async Task AddRangeAsync(IEnumerable<TEntity> entities) => await this.Entities.Set<TEntity>().AddRangeAsync(entities);

        public async  Task<TEntity> ExecWithStoreProcedure(string query, params object[] parameters) =>
            await this.Entities.Set<TEntity>().FromSqlRaw(query, parameters).FirstOrDefaultAsync();

        
        
        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate) => await this.Entities.Set<TEntity>().AsNoTracking().Where(predicate).ToListAsync();

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await this.Entities.Set<TEntity>(). AsNoTracking(). ToListAsync();
        

        public async Task<TEntity> GetByIdAsync(TId id)
       => await this.Entities.Set<TEntity>().FindAsync(id);

       

        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate) => await this.Entities.Set<TEntity>().FirstOrDefaultAsync(predicate);
    }
}
