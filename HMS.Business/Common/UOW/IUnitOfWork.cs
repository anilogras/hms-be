using HMS.Core.Abstracts.Model;
using HMS.DTO;
using HMS.Entities.Models;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DataAccess.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>()
            where TEntity : EnBaseModel, IBaseModel, new();

        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync( CancellationToken cancellationToken = default , bool useTransaction = false);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
