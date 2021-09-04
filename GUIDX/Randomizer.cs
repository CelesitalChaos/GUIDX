#region Namespaces

using System;
using System.Text;

#endregion

namespace GUIDX
{
    /// <summary>
    ///     The <see cref="Randomizer" /> class.
    /// </summary>
    public class Randomizer
    {
        // Instantiate random number generator.  
        private static readonly Random _random = new Random();

        /// <summary>
        ///     Generates a random number within the less specified amount.
        /// </summary>
        /// <param name="maxValue">The maximum.</param>
        /// <returns></returns>
        public static int RandomNumber(int maxValue)
        {
            return _random.Next(maxValue);
        }

        /// <summary>
        ///     Generates a random number within a range.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        ///     Randoms the size of the number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static long RandomNumberSize(int value)
        {
            long val = 0;

            string number = string.Empty;

            for (int i = 0; i < value; i++)
            {
                number += RandomNumber(0, 9);
            }

            val = Convert.ToInt64(number);

            return val;
        }

        /// <summary>
        ///     Generates a random string with a given size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="lowerCase">if set to <c>true</c> [upper case].</param>
        /// <returns></returns>
        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset;
            if (lowerCase)
            {
                offset = 'A';
            }
            else
            {
                offset = 'a';
            }

            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char) _random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            if (lowerCase)
            {
                return builder.ToString().ToUpper();
            }

            return builder.ToString();
        }
    }
}