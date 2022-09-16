using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomUtils
{
    public static class StringUtils
    {
        public static string? ToJsonString(this object obj, bool indented = true)
        {
            JsonSerializerOptions opt = new()
            {
                WriteIndented = indented
            };
            try
            {
                return JsonSerializer.Serialize(obj, obj.GetType(), opt);
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }
    }
}