using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomExtensionMethods
{
    /// <summary>
    /// Class with methods to validate objects.
    /// </summary>
    public static class ValidationMethods
    {
        /// <summary>
        /// Checks that a string is a valid email address (more or less).
        /// </summary>
        public static bool IsValidEmail(this string email)
        {
            string expression = @"^[A-Za-z0-9_\-]{1}[A-Za-z0-9_\-.]+@[A-Za-z0-9_.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(email, expression);
        }
    }
}