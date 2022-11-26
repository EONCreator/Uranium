namespace Uranium.Domain.Data.Repositories
{
    public interface IEntityRepositoryUnitOfWork : IAsyncDisposable
    {
        Task Commit();
        Task Rollback();
    }
}
