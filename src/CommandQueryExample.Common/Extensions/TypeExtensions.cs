using System;
using System.Diagnostics;
using System.Linq;

namespace CommandQueryExample.Common.Extensions
{
    public static class TypeExtensions
    {
        [DebuggerStepThrough]
        public static bool TryGetInterface<T>(this Type type, out Type interfaceType)
        {
            interfaceType = type.GetInterfaces().FirstOrDefault(t => t == typeof (T));

            return interfaceType != null;
        }

        [DebuggerStepThrough]
        public static T Create<T>(this Type type) where T : class
        {
            return type.Create() as T;
        }

        [DebuggerStepThrough]
        public static object Create(this Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}