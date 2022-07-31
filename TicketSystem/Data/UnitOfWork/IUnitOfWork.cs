using System;
using System.Threading;
using System.Threading.Tasks;

namespace TicketSystem.Data.UnitOfWork
{
 
        public interface IUnitOfWork : IDisposable
        {
            int SaveChanges(int? timeout = null);

            Task<int> SaveChangesAsync(int? timeout = null);

            Task<int> SaveChangesAsync(CancellationToken cancellationToken);

            string GetConnection();

            void TrackerClear();

        }
 }
