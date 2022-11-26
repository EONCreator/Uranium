using Microsoft.EntityFrameworkCore;

namespace Uranium.Domain.Data.Repositories
{
    public interface IEntityRepository
    {
        DbSet<TEntity> Entity<TEntity>() where TEntity : class;

        IEntityRepositoryUnitOfWork CreateUnitOfWork();
        Task SaveChanges();
    }
}
