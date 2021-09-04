#region Namespaces

using System;

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

            switch (options.Mode)
            {
                case GUIDType.Alphanumeric:
                {
                    Guid generatedGuid = Guid.NewGuid();
                    generatedText = generatedGuid.ToString();
                    break;
                }

                case GUIDType.Letters:
                {
                    // 8 - 4 - 4 - 12
                    generatedText = Randomizer.RandomString(8) + "-" + Randomizer.RandomString(4) + "-" + Randomizer.RandomString(4) + "-" +
                                    Randomizer.RandomString(4) + "-" + Randomizer.RandomString(12);
                        break;
                }

                case GUIDType.Numeric:
                {
                    // 8 - 4 - 4 - 12
                    generatedText = Randomizer.RandomNumberSize(8) + "-" + Randomizer.RandomNumberSize(4) + "-" + Randomizer.RandomNumberSize(4) + "-" +
                                    Randomizer.RandomNumberSize(4) + "-" + Randomizer.RandomNumberSize(12);
                        break;
                }
            }

            switch (options.Format)
            {
                case GUIDFormat.None:
                {
                    generatedText = generatedText.ToString();
                    break;
                }
                case GUIDFormat.Brackets:
                {
                    generatedText = "{" + generatedText.ToString() + "}";
                    break;
                }
                case GUIDFormat.Parentheses:
                {
                    generatedText = "(" + generatedText.ToString() + ")";
                    break;
                }
                case GUIDFormat.Format1:
                    // [Guid("DD801EC1-1ACC-4473-BB5E-CEF6DDC08BE9")]
                    generatedText = "[Guid(" + @"""" + generatedText.ToString() + @"""" + ")]";
                    break;
                case GUIDFormat.Format2:
                    // <Guid("DD801EC1-1ACC-4473-BB5E-CEF6DDC08BE9")>
                    generatedText = "<Guid(" + @"""" + generatedText.ToString() + @"""" + ")>";
                    break;
                default:
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return generatedText;
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

            switch (options.Mode)
            {
                case GUIDType.Alphanumeric:
                {
                    
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
                    

                    break;
                }

                case GUIDType.Letters:
                {
                    if (amount == 1)
                    {
                        generatedText = GenerateGuidType(options);
                    }
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            string newGuid = GenerateGuidType(options);

                            if (i < amount - 1)
                            {
                                generatedText += newGuid + Environment.NewLine;
                            }
                            else
                            {
                                generatedText += newGuid;
                            }
                        }
                    }
                    break;
                }

                case GUIDType.Numeric:
                {
                    if (amount == 1)
                    {
                        generatedText = GenerateGuidType(options);
                    }
                    else
                    {
                        for (int i = 0; i < amount; i++)
                        {
                            string newGuid = GenerateGuidType(options);

                            if (i < amount - 1)
                            {
                                generatedText += newGuid + Environment.NewLine;
                            }
                            else
                            {
                                generatedText += newGuid;
                            }
                        }
                    }
                    break;
                }
            }

            return generatedText;
        }
    }
}