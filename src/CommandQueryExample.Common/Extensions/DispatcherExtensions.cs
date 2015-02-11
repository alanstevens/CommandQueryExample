using System.Collections.Generic;
using CommandQueryExample.Common.StandardCommands;

namespace CommandQueryExample.Common.Extensions
{
    public static class DispatcherExtensions
    {
        public static void Delete<T>(this IDispatcher dispatcher, T item) where T : class 
        {
            dispatcher.QueueCommand(new DeleteCommand<T>(item));
        }

        public static void Delete<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class 
        {
            dispatcher.QueueCommand(new DeleteManyCommand<T>(items));
        }

        public static void Add<T>(this IDispatcher dispatcher, T item) where T : class
        {
            dispatcher.QueueCommand(new AddCommand<T>(item));
        }

        public static void Add<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class
        {
            dispatcher.QueueCommand(new AddManyCommand<T>(items));
        }

        public static void Update<T>(this IDispatcher dispatcher, T item) where T : class
        {
            dispatcher.QueueCommand(new UpdateCommand<T>(item));
        }

        public static void Update<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class
        {
            dispatcher.QueueCommand(new UpdateManyCommand<T>(items));
        }
    }
}