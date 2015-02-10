using System;
using System.Diagnostics;

namespace CommandQueryExample.Common.Extensions
{
    public static class ObjectExtensions
    {
        [DebuggerStepThrough]
        public static bool IsTypeOf<T>(this object value)
        {
            return value.GetType() == typeof (T);
        }

        [DebuggerStepThrough]
        public static bool IsNot<T>(this object value)
        {
            return !(value is T);
        }

        [DebuggerStepThrough]
        public static bool Is<T>(this object value)
        {
            return value is T;
        }

        [DebuggerStepThrough]
        public static bool IsNull(this object value)
        {
            return ReferenceEquals(value, null);
        }

        [DebuggerStepThrough]
        public static bool IsNotNull(this object value)
        {
            return !ReferenceEquals(value, null);
        }

        [DebuggerStepThrough]
        public static T As<T>(this object value)
        {
            var result = default(T);

            if (value.IsNull()) return result;

            //if (value is String && value.ToString().Blank()) return (T) (String.Empty as object);

            try
            {
                if (result is String) return (T) (Convert.ToString(value) as object);

                if (result is ValueType)
                {
                    if (result is Boolean) return (T) (Convert.ToBoolean(value) as object);
                    if (result is Byte) return (T) (Convert.ToByte(value) as object);
                    if (result is Char) return (T) (Convert.ToChar(value) as object);
                    if (result is Decimal) return (T) (Convert.ToDecimal(value) as object);
                    if (result is Double) return (T) (Convert.ToDouble(value) as object);
                    if (result is Int16) return (T) (Convert.ToInt16(value) as object);
                    if (result is Int32) return (T) (Convert.ToInt32(value) as object);
                    if (result is Int64) return (T) (Convert.ToInt64(value) as object);
                    if (result is SByte) return (T) (Convert.ToSByte(value) as object);
                    if (result is Single) return (T) (Convert.ToSingle(value) as object);
                    if (result is UInt16) return (T) (Convert.ToUInt16(value) as object);
                    if (result is UInt32) return (T) (Convert.ToUInt32(value) as object);
                    if (result is UInt64) return (T) (Convert.ToUInt64(value) as object);
                    if (result is Guid) return (T) (new Guid(value.ToString()) as object);
                    if (result is DateTime)
                    {
                        try
                        {
                            return (T) (Convert.ToDateTime(value) as object);
                        }
                        catch (InvalidCastException)
                        {
                            return (T) (DateTime.Parse(value.ToString()) as object);
                        }
                    }
                }
                result = (T) value;
            }
            catch (InvalidCastException ex)
            {
                LogException(ex);
            }
            catch (FormatException ex)
            {
                LogException(ex);
            }
            catch (ArgumentNullException ex)
            {
                LogException(ex);
            }
            catch (OverflowException ex)
            {
                LogException(ex);
            }

            return result;
        }

        static void LogException(Exception ex)
        {
            // Log the exception and return the default value.
            typeof (ObjectExtensions).LogException(ex);
            Debug.Assert(false, "Failed to convert type.");
        }
    }
}