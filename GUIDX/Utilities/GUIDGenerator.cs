#region Namespaces

using System;

using GUIDX.Enums;

#endregion

namespace GUIDX.Utilities
{
    /// <summary>
    ///     The <see cref="GUIDGenerator" /> class.
    /// </summary>
    public class GUIDGenerator
    {
        /// <summary>
        /// Generates the type of the unique identifier.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        private static string GenerateGuidType(GUIDGenerationOptions options)
        {
            string generatedText = string.Empty;

            switch (options.Format)
            {
                case GUIDFormat.Alphanumeric:
                {
                    Guid generatedGuid = Guid.NewGuid();
                    generatedText = generatedGuid.ToString();

                    if (options.UpperCase)
                    {
                        generatedText = generatedText.ToUpper();
                    }

                    break;
                }

                case GUIDFormat.Letters:
                {
                    // 8 - 4 - 4 - 12
                    generatedText = Randomizer.RandomString(8, options.UpperCase) + "-" + Randomizer.RandomString(4, options.UpperCase) + "-" + Randomizer.RandomString(4, options.UpperCase) + "-" +
                                    Randomizer.RandomString(4, options.UpperCase) + "-" + Randomizer.RandomString(12, options.UpperCase);
                        break;
                }

                case GUIDFormat.Numeric:
                {
                    // 8 - 4 - 4 - 12
                    generatedText = Randomizer.RandomNumberSize(8) + "-" + Randomizer.RandomNumberSize(4) + "-" + Randomizer.RandomNumberSize(4) + "-" +
                                    Randomizer.RandomNumberSize(4) + "-" + Randomizer.RandomNumberSize(12);
                        break;
                }
            }

            generatedText = GeneratePrefixSuffix(generatedText, options);
            
            return generatedText;
        }

        /// <summary>
        /// Generates the prefix suffix.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="options">The options.</param>
        /// <returns>The <see cref="string"/> value.</returns>
        private static string GeneratePrefixSuffix(string value, GUIDGenerationOptions options)
        {
            string generatePrefixSuffix = value;

            if (options.Prefix && options.Suffix)
            {
                generatePrefixSuffix = options.PrefixText + value + options.SuffixText;
            }
            else if (options.Prefix)
            {
                generatePrefixSuffix = options.PrefixText + value;
            }
            else if (options.Suffix)
            {
                generatePrefixSuffix = value + options.SuffixText;
            }

            return generatePrefixSuffix;
        }

        /// <summary>
        /// Generates the specified type.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>The <see cref="string"/> value.</returns>
        public static string Generate(GUIDGenerationOptions options, int amount = 1)
        {
            string generatedText = string.Empty;

            for (int i = 0; i < amount; i++)
            {
                string newGuid = GenerateGuidType(options);

                if (amount == 1)
                {
                    generatedText = GenerateGuidType(options);
                }
                else if (i < amount - 1)
                {
                    generatedText += newGuid + Environment.NewLine;
                }
                else
                {
                    generatedText += newGuid;
                }
            }

            return generatedText;
        }
    }
}