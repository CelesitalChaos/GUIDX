#region Namespaces

using System;
using System.Text.RegularExpressions;

#endregion

namespace GUIDX.Utilities
{
    /// <summary>
    ///     The <see cref="GUIDValidator" /> class.
    /// </summary>
    public class GUIDValidator
    {
        /// <summary>
        ///     Determines whether the specified input is unique identifier.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///     <c>true</c> if the specified input is unique identifier; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGUIDRegex(string input)
        {
            if (input != null)
            {
                Regex guidRegEx =
                    new Regex(
                        @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$");

                return guidRegEx.IsMatch(input);
            }

            return false;
        }

        /// <summary>
        ///     Determines whether the specified value is unique identifier.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///     <c>true</c> if the specified value is unique identifier; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsGUIDParse(string value)
        {
            return Guid.TryParse(value, out _);
        }
    }
}