using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common
{
    /// <summary>
    ///     Adapted from http://kigg.codeplex.com/
    /// </summary>
    [Serializable]
    public class Verify
    {
        internal Verify() {}

        [DebuggerStepThrough]
        public static void NotEmpty(Guid argument, string argumentName)
        {
            if (argument == Guid.Empty) throw new ArgumentException(argumentName + " cannot be empty guid.", argumentName);
        }

        [DebuggerStepThrough]
        public static void NotEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty((argument ?? string.Empty).Trim()))
                throw new ArgumentException(argumentName + " cannot be empty.", argumentName);
        }

        [DebuggerStepThrough]
        public static void NotEmpty(int argument, string argumentName)
        {
            if (argument <= 0) throw new ArgumentException(argumentName + " cannot be empty.", argumentName);
        }

        [DebuggerStepThrough]
        public static void NotEmpty(TimeSpan argument, string argumentName)
        {
            if (Math.Abs(argument.TotalMilliseconds - 0.0F) == 0) throw new ArgumentException(argumentName + " cannot be empty.", argumentName);
        }

        [DebuggerStepThrough]
        public static void WithinLength(string argument, int length, string argumentName)
        {
            if (argument.Trim().Length > length)
                throw new ArgumentException(argumentName + " cannot be more than " + length + " characters", argumentName);
        }

        [DebuggerStepThrough]
        public static void Null(object argument, string argumentName)
        {
            if (argument != null) throw new ArgumentException(argumentName + " must be null", argumentName);
        }

        [DebuggerStepThrough]
        public static void NotNull(object argument, string argumentName)
        {
            if (argument.IsNull()) throw new ArgumentNullException(argumentName);
        }

        [DebuggerStepThrough]
        public static void PositiveOrZero(int argument, string argumentName)
        {
            if (argument < 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void Positive(int argument, string argumentName)
        {
            if (argument <= 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void PositiveOrZero(long argument, string argumentName)
        {
            if (argument < 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void Positive(long argument, string argumentName)
        {
            if (argument <= 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void PositiveOrZero(float argument, string argumentName)
        {
            if (argument < 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void Positive(float argument, string argumentName)
        {
            if (argument <= 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void PositiveOrZero(decimal argument, string argumentName)
        {
            if (argument < 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void Positive(decimal argument, string argumentName)
        {
            if (argument <= 0) throw new ArgumentOutOfRangeException(argumentName);
        }

        /*
          [DebuggerStepThrough]
          public static void ValidDate(DateTime argument, string argumentName)
          {
              if (!argument.IsValid())
                  throw new ArgumentOutOfRangeException(argumentName);
          }

          [DebuggerStepThrough]
          public static void InFuture(DateTime argument, string argumentName)
          {
              if (argument < SystemTime.Now())
                  throw new ArgumentOutOfRangeException(argumentName);
          }

          [DebuggerStepThrough]
          public static void InPast(DateTime argument, string argumentName)
          {
              if (argument > SystemTime.Now())
                  throw new ArgumentOutOfRangeException(argumentName);
          }
          */

        [DebuggerStepThrough]
        public static void PositiveOrZero(TimeSpan argument, string argumentName)
        {
            if (argument < TimeSpan.Zero) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void Positive(TimeSpan argument, string argumentName)
        {
            if (argument <= TimeSpan.Zero) throw new ArgumentOutOfRangeException(argumentName);
        }

        [DebuggerStepThrough]
        public static void NotEmpty<T>(IEnumerable<T> argument, string argumentName)
        {
            NotNull(argument, argumentName);

            if (!argument.Any()) throw new ArgumentException("Enumerable cannot be empty.", argumentName);
        }

        [DebuggerStepThrough]
        public static void InRange(int argument, int min, int max, string argumentName)
        {
            if ((argument < min) || (argument > max))
                throw new ArgumentOutOfRangeException(argumentName, argumentName + "must be between " + min + "-" + max + ".");
        }

        public static void AreEqual<T>(T expected, T actual, string argumentName)
        {
            if (!EqualityComparer<T>.Default.Equals(expected, actual))
            {
                throw new ArgumentOutOfRangeException(argumentName,
                                                      argumentName + " must be " + expected + ", but was " + actual + ".");
            }
        }

        public static void True(bool actual, string argumentName)
        {
            AreEqual(true, actual, argumentName);
        }

        public static void False(bool actual, string argumentName)
        {
            AreEqual(false, actual, argumentName);
        }

        public static void AreNotEqual<T>(T expected, T actual, string argumentName)
        {
            if (EqualityComparer<T>.Default.Equals(expected, actual))
                throw new ArgumentOutOfRangeException(argumentName, argumentName + " must not be equal to " + expected + ".");
        }

        /*
         [DebuggerStepThrough]
         public static void NotInvalidEmail(string argument, string argumentName)
         {
             NotEmpty(argument, argumentName);

             if (!argument.IsEmail())
             {
                 throw new ArgumentException("\"{0}\" is not a valid email address.".FormatWith(argumentName), argumentName);
             }
         }


         [DebuggerStepThrough]
         public static void NotInvalidWebUrl(string argument, string argumentName)
         {
             NotEmpty(argument, argumentName);

             if (!argument.IsWebUrl())
             {
                 throw new ArgumentException("\"{0}\" is not a valid web url.".FormatWith(argumentName), argumentName);
             }
         }
          */

        [DebuggerStepThrough]
        public static void ValidID(int? id, string argumentName)
        {
            NotNull(id, argumentName);
            Positive(id.Value, argumentName);
        }
    }
}