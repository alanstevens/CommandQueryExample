using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using CommandQueryExample.Common;

namespace CommandQueryExample.Data
{
    public class Dispatcher : IDispatcher
    {
        static DbContext Context
        {
            get
            {
                var currentContext = DataContextFactory.CurrentContext;
                return ((DataContext) currentContext).Context;
            }
        }

        public IEnumerable<T> Get<T>(QueryBase<T> query) where T : class
        {
            return query.Call(Context.Set<T>());
        }

        public async Task<IEnumerable<T>> GetAsync<T>(AsyncQueryBase<T> query) where T : class
        {
            return await query.CallAsync(Context.Set<T>());
        }

        public T Find<T>(ScalarQueryBase<T> query) where T : class
        {
            return query.Call(Context.Set<T>());
        }

        public async Task<T> FindAsync<T>(AsyncScalarQueryBase<T> query) where T : class
        {
            return await query.CallAsync(Context.Set<T>());
        }

        public void QueueCommand<T>(CommandBase<T> command) where T : class
        {
            command.MarkAsModified = MarkAsModified;
            command.MarkAsAdded = MarkAsAdded;
            command.MarkAsDeleted = MarkAsDeleted;

            command.Execute(Context.Set<T>());

            command.MarkAsModified = x => x;
            command.MarkAsAdded = x => x;
            command.MarkAsDeleted = x => { };
        }

        static T MarkAsModified<T>(T entity) where T : class
        {
            AttachIfNeeded(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        static T MarkAsAdded<T>(T entity) where T : class
        {
            AttachIfNeeded(entity);
            Context.Entry(entity).State = EntityState.Added;
            return entity;
        }

        static void MarkAsDeleted<T>(T entity) where T : class
        {
            AttachIfNeeded(entity);
            Context.Entry(entity).State = EntityState.Deleted;
        }

        static void AttachIfNeeded<T>(T entity) where T : class
        {
            if (Context.Entry(entity).State == EntityState.Detached)
                Context.Set<T>().Attach(entity);
        }
    }
}