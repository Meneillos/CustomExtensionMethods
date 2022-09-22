using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomUtils
{
    /// <summary>
    /// Class with methods that works with generics.
    /// </summary>
    public static class GenericMethods
    {
        /// <summary>
        /// Converts an object to a json string.
        /// </summary>
        public static string? ToJsonString<T>(this T obj, bool indented = true)
        {
            JsonSerializerOptions opt = new()
            {
                WriteIndented = indented
            };
            try
            {
                return JsonSerializer.Serialize(obj, obj!.GetType(), opt);
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Converts string to integer.
        /// </summary>
        public static int? ToInt(this string number)
        {
            try
            {
                Int32.TryParse(number, out int value);
                return value;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}