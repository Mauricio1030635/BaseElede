using EledeRepaso.Core.RepositoriosNegocio;

namespace EledeRepaso.Core.Repositories
{
    public interface IDataUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        Task BeginTransactionAsync();
        Task<int> CommitAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
