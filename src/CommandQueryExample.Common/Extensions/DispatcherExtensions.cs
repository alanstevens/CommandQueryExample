using System.Collections.Generic;
using CommandQueryExample.Common.StandardCommands;

namespace CommandQueryExample.Common.Extensions
{
    public static class DispatcherExtensions
    {
        public static void Remove<T>(this IDispatcher dispatcher, T item) where T : class 
        {
            dispatcher.QueueCommand(new RemoveCommand<T>(item));
        }

        public static void RemoveRange<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class 
        {
            dispatcher.QueueCommand(new RemoveRangeCommand<T>(items));
        }

        public static void Add<T>(this IDispatcher dispatcher, T item) where T : class
        {
            dispatcher.QueueCommand(new AddCommand<T>(item));
        }

        public static void AddRange<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class
        {
            dispatcher.QueueCommand(new AddRangeCommand<T>(items));
        }

        public static void Update<T>(this IDispatcher dispatcher, T item) where T : class
        {
            dispatcher.QueueCommand(new UpdateCommand<T>(item));
        }

        public static void UpdateRange<T>(this IDispatcher dispatcher, IEnumerable<T> items) where T : class
        {
            dispatcher.QueueCommand(new UpdateRangeCommand<T>(items));
        }
    }
}