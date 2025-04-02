using AutoMapper;
using HMS.Core.Abstracts.Model;
using HMS.DataAccess.Context;
using HMS.Entities.Models.Base;
using HMS.Entities.Models.Definition.FrontOffice;
using Microsoft.EntityFrameworkCore.Storage;

namespace HMS.DataAccess.Common
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly IMapper _mapper;
        private readonly HMSContext _context;

        private IDbContextTransaction? _transaction;

        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(HMSContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_transaction == null)
            {
                _transaction = await _context.Database.BeginTransactionAsync(cancellationToken);
            }
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default, bool useTransaction = false)
        {
            try
            {
                if (useTransaction)
                {
                    await BeginTransactionAsync(cancellationToken);
                }

                int result = await _context.SaveChangesAsync(cancellationToken);

                if (useTransaction && _transaction != null)
                {
                    await _transaction.CommitAsync(cancellationToken);
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }

                return result;
            }
            catch
            {
                if (_transaction != null)
                {
                    await RollbackAsync();
                }
                throw;
            }
        }

        public async Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync(cancellationToken);
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public IRepository<T> Repository<T>() where T : EnBaseModel, IBaseModel, new()
        {
            if (!_repositories.ContainsKey(typeof(T)))
            {
                var repositoryInstance = new Repository<T>(_context);
                _repositories.Add(typeof(T), repositoryInstance);
            }

            return (IRepository<T>)_repositories[typeof(T)];
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
