using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace TicketSystem.Helper;
public static class IQueryableExtensions
{
        public static IQueryable<T> Including<T>(this IQueryable<T> source, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    source = source.Include(includeProperty);
                }
            }

            return source;
        }

        public static IQueryable<T> Including<T>(this IQueryable<T> source, params string[] includeProperties) where T : class
        {
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    source = source.Include(includeProperty);
                }
            }

            return source;
        }

}