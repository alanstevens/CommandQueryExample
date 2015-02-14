using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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

        public IEnumerable<T> Get<T>(BaseQuery<T> query) where T : class
        {
            return query.Call(Context.Set<T>());
        }

        public async Task<IEnumerable<T>> GetAsync<T>(BaseAsyncQuery<T> query) where T : class
        {
            return await query.CallAsync(Context.Set<T>());
        }

        public T GetScalar<T>(BaseScalarQuery<T> query) where T : class
        {
            return query.Call(Context.Set<T>());
        }

        public async Task<T> GetScalarAsync<T>(BaseAsyncScalarQuery<T> query) where T : class
        {
            return await query.CallAsync(Context.Set<T>());
        }

        public void QueueCommand<T>(BaseCommand<T> command) where T : class
        {
            command.MarkAsModified = MarkAsModified;
            command.MarkAsAdded = MarkAsAdded;
            command.MarkAsDeleted = MarkAsDeleted;

            command.Execute(Context.Set<T>());

            command.MarkAsModified = x => { };
            command.MarkAsAdded = x => { };
            command.MarkAsDeleted = x => { };
        }

        static void MarkAsModified<T>(T entity) where T : class
        {
            var entry = GetEntry(entity);
            AttachIfNeeded(entry);
            entry.State = EntityState.Modified;
        }

        static void MarkAsAdded<T>(T entity) where T : class
        {
            var entry = GetEntry(entity);
            AttachIfNeeded(entry);
            entry.State = EntityState.Added;
        }

        static void MarkAsDeleted<T>(T entity) where T : class
        {
            var entry = GetEntry(entity);
            AttachIfNeeded(entry);
            entry.State = EntityState.Deleted;
        }

        static DbEntityEntry<T> GetEntry<T>(T entity) where T : class
        {
            return Context.Entry(entity);
        }

        static void AttachIfNeeded<T>(DbEntityEntry<T> entry) where T : class
        {
            if (entry.State == EntityState.Detached)
                Context.Set<T>().Attach(entry.Entity);
        }
    }
}