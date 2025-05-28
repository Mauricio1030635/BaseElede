using EledeRepaso.Core.Repositories;
using EledeRepaso.Core.RepositoriosNegocio;
using EledeRepaso.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EledeRepaso.Data.Implementacion
{
    public class DataUnitOfWork : IDataUnitOfWork
    {
        private readonly EledeDBContext context;

        private ProductRepository productRepository;
        public DataUnitOfWork(EledeDBContext context)
        {
            this.context = context;
        }

        public IProductRepository Products => this.productRepository ??= new ProductRepository(this.context);

        public async Task BeginTransactionAsync() => await this.context.Database.BeginTransactionAsync();
        public async Task<int> CommitAsync() => await this.context.SaveChangesAsync();

        public async Task CommitTransactionAsync() =>
            await this.context.Database.CommitTransactionAsync();


        public void Dispose() => this.context.Dispose();

        public async Task RollbackTransactionAsync() => await this.context.Database.RollbackTransactionAsync();
    }
}
