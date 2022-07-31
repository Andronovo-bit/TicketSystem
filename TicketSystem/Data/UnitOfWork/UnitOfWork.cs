
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using TicketSystem.Data.Context;

namespace TicketSystem.Data.UnitOfWork
{
 
        public class UnitOfWork : IUnitOfWork
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly DbContext _dataContext;
            private bool _disposed;

            public UnitOfWork(
                TicketSystemDataContext dataContext,
                IHttpContextAccessor httpContextAccessor)
            {
                _httpContextAccessor = httpContextAccessor;
                _dataContext = dataContext;
            }

            ~UnitOfWork()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected void CheckDisposed()
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException("The UnitOfWork is already disposed and cannot be used anymore.");
                }
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        if (_dataContext != null)
                        {
                            _dataContext.Dispose();
                        }
                    }
                }
                _disposed = true;
            }

            public int SaveChanges(int? timeout = null)
            {
                if (timeout.HasValue)
                {
                    _dataContext.Database.SetCommandTimeout(timeout.Value);
                }
                CheckDisposed();

                return _dataContext.SaveChanges();
            }

            public Task<int> SaveChangesAsync(int? timeout = null)
            {
                if (timeout.HasValue)
                {
                    _dataContext.Database.SetCommandTimeout(timeout.Value);
                }
                CheckDisposed();

                return _dataContext.SaveChangesAsync();
            }

            public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
            {
                CheckDisposed();
                return _dataContext.SaveChangesAsync(cancellationToken);
            }

            public string GetConnection()
            {
                return _dataContext.Database.GetDbConnection().ConnectionString;
            }

            public void TrackerClear()
            {
                _dataContext.ChangeTracker.Clear();
            }


    }
    }
 