using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace CommandQueryExample.Common.Extensions
{
    public static class StringExtensions
    {
        [DebuggerStepThrough]
        public static string ToProperCase(this string value)
        {
            Verify.NotEmpty(value, "value");
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }

        [DebuggerStepThrough]
        public static bool Blank(this string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        [DebuggerStepThrough]
        public static bool IsNotBlank(this string value)
        {
            return !String.IsNullOrWhiteSpace(value);
        }

        [DebuggerStepThrough]
        public static string FormatWith(this string stringFormat, params object[] args)
        {
            return String.Format(CultureInfo.InvariantCulture, stringFormat, args);
        }

        [DebuggerStepThrough]
        public static string FormatSQL(this string stringFormat, params object[] args)
        {
            var strings = Array.ConvertAll(args, a => a.ToString().SanitizeSQL());
            return String.Format(CultureInfo.InvariantCulture, stringFormat, strings);
        }

        [DebuggerStepThrough]
        public static string CalculateHash(this string value)
        {
            Verify.NotEmpty(value, "value");

            var data = Encoding.UTF8.GetBytes(value);
            var hash = data.CalculateHash();

            return hash.ToBase64();
        }

        [DebuggerStepThrough]
        public static byte[] CalculateHash(this byte[] value)
        {
            Verify.NotEmpty(value, "value");

            using (var hashAlgorithm = HMAC.Create())
            {
                var hash = hashAlgorithm.ComputeHash(value);

                return hash;
            }
        }

        [DebuggerStepThrough]
        public static string CalculateMd5Hash(this string value)
        {
            Verify.NotEmpty(value, "value");

            using (var md5 = MD5.Create())
            {
                var data = Encoding.UTF8.GetBytes(value);
                var hash = md5.ComputeHash(data);

                return hash.ToBase64();
            }
        }

        [DebuggerStepThrough]
        public static string Base64ToHex(this string base64)
        {
            var hashBytes = Convert.FromBase64String(base64);

            return hashBytes.ToHex();
        }

        [DebuggerStepThrough]
        public static string HexToBase64(this string hex)
        {
            var hashBytes = HexToBinary(hex);

            return Convert.ToBase64String(hashBytes);
        }

        [DebuggerStepThrough]
        public static Byte[] HexToBinary(this string hex)
        {
            var numberChars = hex.Length;
            if (numberChars%2 == 1) hex = '0' + hex;
            var bytes = new byte[numberChars/2];
            for (var i = 0; i < numberChars; i += 2) bytes[i/2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        [DebuggerStepThrough]
        public static string ToHex(this byte[] input)
        {
            return BitConverter.ToString(input).Replace("-", string.Empty);
        }

        [DebuggerStepThrough]
        public static string ToBase64(this byte[] input)
        {
            return Convert.ToBase64String(input);
        }

        [DebuggerStepThrough]
        public static T ToEnum<T>(this string value, T defaultValue) where T : IComparable, IFormattable
        {
            var convertedValue = defaultValue;

            if (value.IsNotBlank())
            {
                try
                {
                    convertedValue = (T) Enum.Parse(typeof (T), value.Trim(), true);
                }
                catch (ArgumentException) {}
            }

            return convertedValue;
        }

        [DebuggerStepThrough]
        public static string Join(this IEnumerable<string> values, string separator = null)
        {
            return Join(values.ToArray(), separator);
        }

        [DebuggerStepThrough]
        public static string Join(this string[] values, string separator = null)
        {
            if (separator.IsNull()) separator = ",";
            return String.Join(separator, values);
        }

        [DebuggerStepThrough]
        public static string SanitizeSQL(this string value)
        {
            return value.Replace("'", "''").Replace("\\", "\\\\");
        }
    }
}