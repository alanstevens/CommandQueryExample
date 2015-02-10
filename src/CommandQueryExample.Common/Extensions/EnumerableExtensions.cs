using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;

namespace CommandQueryExample.Common.Extensions
{
    public static class EnumerableExtensions
    {
        [DebuggerStepThrough]
        public static void RemoveWhere<T>(this IList<T> list, Func<T, bool> whereEvaluator)
        {
            for (var i = list.Count - 1; i >= 0; i--) if (whereEvaluator(list[i])) list.RemoveAt(i);
        }

        [DebuggerStepThrough]
        public static IEnumerable<T> Each<T>(this IEnumerable<T> values, Action<T> eachAction)
        {
            foreach (var item in values) eachAction(item);

            return values;
        }

        [DebuggerStepThrough]
        public static IEnumerable Each(this IEnumerable values, Action<object> eachAction)
        {
            foreach (var item in values) eachAction(item);

            return values;
        }

        [DebuggerStepThrough]
        public static TReturn FirstValue<TItem, TReturn>(this IEnumerable<TItem> enumerable, Func<TItem, TReturn> func)
            where TReturn : class
        {
            foreach (var item in enumerable)
            {
                var @object = func(item);
                if (@object != null) return @object;
            }

            return null;
        }

        [DebuggerStepThrough]
        public static IList<T> AddMany<T>(this IList<T> list, params T[] items)
        {
            return list.AddRange(items);
        }

        [DebuggerStepThrough]
        public static IList<T> AddRange<T>(this IList<T> list, IEnumerable<T> items)
        {
            items.Each(list.Add);
            return list;
        }

        [DebuggerStepThrough]
        public static bool IsEqualTo<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            var actualList = actual.ToArray();
            var expectedList = expected.ToArray();

            if (actualList.Length != expectedList.Length) return false;

            for (var i = 0; i < actualList.Length; ++i) if (!actualList[i].Equals(expectedList[i])) return false;

            return true;
        }

        [DebuggerStepThrough]
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return (enumerable.IsNull() || !enumerable.Any());
        }

        [DebuggerStepThrough]
        public static T GetValue<T>(this NameValueCollection collection, string key)
        {
            return collection[key].As<T>();
        }

        [DebuggerStepThrough]
        public static int IndexOf<T>(this IEnumerable<T> items, T item)
        {
            return items.FindIndex(i => EqualityComparer<T>.Default.Equals(item, i));
        }

        [DebuggerStepThrough]
        static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            Verify.NotNull(items, "items");
            Verify.NotNull(predicate, "predicate");

            var result = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return result;
                result++;
            }
            return -1;
        }
    }
}