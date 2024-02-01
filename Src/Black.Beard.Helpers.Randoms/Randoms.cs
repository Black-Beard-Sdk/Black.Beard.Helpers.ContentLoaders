using RandomDataGenerator.CreditCardValidator;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb
{
    public class Randoms
    {


        /// <summary>
        /// Generates the string list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public static RandomizerStringList GenerateStringList(IEnumerable<string> list)
        {
            return new RandomizerStringList(new FieldOptionsStringList()
            {
                Values = list
            });
        }

        /// <summary>
        /// Generates boolean.
        /// </summary>
        /// <returns></returns>
        public static RandomizerNumber<bool> GenerateBoolean()
        {
            return new RandomizerNumber<bool>(new FieldOptionsBoolean()
            {
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the card.
        /// </summary>
        /// <param name="cardIssuer">The card issuer.</param>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static RandomizerCCN GenerateCard(CardIssuer cardIssuer, int length = 0)
        {
            return new RandomizerCCN(new FieldOptionsCCN()
            {
                CardIssuer = cardIssuer,
                Length = length,
            });
        }

        /// <summary>
        /// Generates the integer.
        /// </summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <returns></returns>
        public static RandomizerNumber<int> GenerateInteger(int min = 0, int max = int.MaxValue)
        {
            return new RandomizerNumber<int>(new FieldOptionsInteger()
            {
                Min = min,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the byte.
        /// </summary>
        /// <param name="min">The minimum value.</param>
        /// <param name="max">The maximum value.</param>
        /// <param name="useNullValues">if set to <c>true</c> [use null values].</param>
        /// <returns></returns>
        public static RandomizerNumber<byte> GenerateByte(byte min = 0, byte max = byte.MaxValue)
        {
            return new RandomizerNumber<byte>(new FieldOptionsByte()
            {
                Min = 0,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the double.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerNumber<double> GenerateDouble(double min = 0, double max = double.MaxValue)
        {
            return new RandomizerNumber<double>(new FieldOptionsDouble()
            {
                Min = min,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the binary.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static IRandomizerBytes GenerateBinary(int min = 0, int max = int.MaxValue)
        {
            return new RandomizerBytes(new FieldOptionsBytes()
            {
                Min = min,
                Max = max,
            });
        }

        /// <summary>
        /// Generates the float.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerNumber<float> GenerateFloat(float min = 0, float max = float.MaxValue)
        {
            return new RandomizerNumber<float>(new FieldOptionsFloat()
            {
                Min = min,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the short.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerNumber<short> GenerateShort(short min = 0, short max = short.MaxValue)
        {
            return new RandomizerNumber<short>(new FieldOptionsShort()
            {
                Min = min,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the long.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerNumber<long> GenerateLong(long min = 0, long max = long.MaxValue)
        {
            return new RandomizerNumber<long>(new FieldOptionsLong()
            {
                Min = min,
                Max = max,
                UseNullValues = false,
            });
        }

        /// <summary>
        /// Generates the text.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public static RandomizerText GenerateText(int min = 0, int max = int.MaxValue, TextTandomizeContextEnum context = TextTandomizeContextEnum.All)
        {
            return new RandomizerText(new FieldOptionsText()
            {
                Min = min,
                Max = max,
                Seed = 2,
                UseLetter = (context & TextTandomizeContextEnum.UseLetter) == TextTandomizeContextEnum.UseLetter,
                UseNumber = (context & TextTandomizeContextEnum.UseNumber) == TextTandomizeContextEnum.UseNumber,
                UseSpace = (context & TextTandomizeContextEnum.UseSpace) == TextTandomizeContextEnum.UseSpace,
                UseLowercase = (context & TextTandomizeContextEnum.UseLowercase) == TextTandomizeContextEnum.UseLowercase,
                UseUppercase = (context & TextTandomizeContextEnum.UseUppercase) == TextTandomizeContextEnum.UseUppercase,
                UseSpecial = (context & TextTandomizeContextEnum.UseSpecial) == TextTandomizeContextEnum.UseSpecial,
            });
        }

        /// <summary>
        /// Generates the text by regex.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public static RandomizerTextRegex GenerateTextByRegex(string pattern)
        {
            return new RandomizerTextRegex(new FieldOptionsTextRegex()
            {
                Seed = 2,
                Pattern = pattern,
            });
        }



        // 

        /// <summary>
        /// Generates the text by pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public static RandomizerTextPattern GenerateTextPattern(string pattern)
        {
            return new RandomizerTextPattern(new FieldOptionsTextPattern()
            {
                Seed = 2,
                Pattern = pattern,
            });
        }


        /// <summary>
        /// Generates the text words.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerTextWords GenerateTextWords(int min = 1, int max = int.MaxValue)
        {
            return new RandomizerTextWords(new FieldOptionsTextWords()
            {
                Seed = 2, 
                Min = min, 
                Max = max,                
            });
        }

        /// <summary>
        /// Generates the date time.
        /// </summary>
        /// <param name="includeTime">if set to <c>true</c> [include time].</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public static RandomizerDateTime GenerateDateTime(bool includeTime = true, DateTime? from = null, DateTime? to = null)
        {
            return new RandomizerDateTime(new FieldOptionsDateTime()
            {
                Seed = 2,
                //Format = format,
                IncludeTime = includeTime,
                From = from.HasValue ? (includeTime ? from.Value : from.Value.Date) : (includeTime ? DateTime.UtcNow : DateTime.UtcNow.Date),
                To = to.HasValue ? (includeTime ? to.Value : to.Value.Date) : (includeTime ? DateTime.UtcNow.AddYears(1) : DateTime.UtcNow.AddYears(1).Date),
            });
        }

        /// <summary>
        /// Generates the time span.
        /// </summary>
        /// <param name="includeMilliseconds">if set to <c>true</c> [include milliseconds].</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public static RandomizerTimeSpan GenerateTimeSpan(bool includeMilliseconds = true, TimeSpan? from = null, TimeSpan? to = null)
        {
            return new RandomizerTimeSpan(new FieldOptionsTimeSpan()
            {
                UseNullValues = false,
                ValueAsString = true,
                Seed = 2,
                IncludeMilliseconds = includeMilliseconds,
                From = from.HasValue ? from.Value : new TimeSpan(0, 0, 0),
                To = to.HasValue ? to.Value : new TimeSpan(23, 59, 59),
                Format = "",
            });
        }

        /// <summary>
        /// Generates the email address.
        /// </summary>
        /// <param name="female">if set to <c>true</c> [female].</param>
        /// <param name="male">if set to <c>true</c> [male].</param>
        /// <param name="left2Right">if set to <c>true</c> [left2 right].</param>
        /// <returns></returns>
        public static RandomizerEmailAddress GenerateEmailAddress(bool female = true, bool male = true, bool left2Right = true)
        {
            return new RandomizerEmailAddress(new FieldOptionsEmailAddress()
            {
                Female = female,
                Male = male,
                Left2Right = left2Right,
                Seed = 2
            });
        }

        /// <summary>
        /// Generates the ip v4.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static RandomizerIPv4Address GenerateIpV4(string min = null, string max = null)
        {
            return new RandomizerIPv4Address(new FieldOptionsIPv4Address()
            {
                Min = min,
                Max = max
            });
        }

        /// <summary>
        /// Generates the ip v6.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
        /// <returns></returns>
        public static RandomizerIPv6Address GenerateIpV6(string min = null, string max = null, bool upperCase = true)
        {
            return new RandomizerIPv6Address(new FieldOptionsIPv6Address()
            {
                Min = min,
                Max = max,
                Uppercase = upperCase
            });
        }

        /// <summary>
        /// Generates the city.
        /// </summary>
        /// <returns></returns>
        public static RandomizerCity GenerateCity()
        {
            return new RandomizerCity(new FieldOptionsCity());
        }


        /// <summary>
        /// Generates the last name.
        /// </summary>
        /// <returns></returns>
        public static RandomizerLastName GenerateLastName()
        {
            return new RandomizerLastName(new FieldOptionsLastName());
        }

        /// <summary>
        /// Generates the country.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static RandomizerCountry GenerateCountry()
        {
            return new RandomizerCountry(new FieldOptionsCountry());
        }

        /// <summary>
        /// Generates the first name.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static RandomizerFirstName GenerateFirstName()
        {
            return new RandomizerFirstName(new FieldOptionsFirstName()
            {
                Female = true,
                Male = true,
                Seed = 2,
            });
        }

        /// <summary>
        /// Generates the full name.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static RandomizerFullName GenerateFullName()
        {
            return new RandomizerFullName(new FieldOptionsFullName()
            {
                Female = true,
                Left2Right = true,
                Male = true,
                Seed = 2
            });
        }

        /// <summary>
        /// Generates the iban bban.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        public static RandomizerIBAN GenerateIbanBban(string countryCode)
        {
            return new RandomizerIBAN(new FieldOptionsIBAN() { CountryCode = countryCode, Seed = 2, Type = "BBAN" });
        }

        /// <summary>
        /// Generates the iban both.
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <returns></returns>
        public static RandomizerIBAN GenerateIbanBoth(string countryCode)
        {
            return new RandomizerIBAN(new FieldOptionsIBAN() { CountryCode = countryCode, Seed = 2, Type = "BOTH" });
        }


        public static RandomizerTextLipsum GenerateLipsum(int paragraphs = 3)
        {
            return new RandomizerTextLipsum(new FieldOptionsTextLipsum()
            {
                Paragraphs = paragraphs,
            });
        }


        /// <summary>
        /// Generates the naughty strings.
        /// </summary>
        /// <param name="categories">The category.
        /// <summary>
        /// A comma separated string from one or more from these categories:
        /// All
        /// Changinglengthwhenlowercased
        /// CommandInjectionRuby
        /// Emoji
        /// FileInclusion
        /// Humaninjection
        /// JapaneseEmoticons
        /// KnownCVEsandVulnerabilities
        /// MSDOSWindowsSpecialFilenames
        /// NumericStrings
        /// OghamText
        /// QuotationMarks
        /// ReservedStrings
        /// RightToLeftStrings
        /// SQLInjection
        /// ScriptInjection
        /// ScunthorpeProblem
        /// ServerCodeInjection
        /// SpecialCharacters
        /// SpecialUnicodeCharactersUnion
        /// Stringswhichcontaintwobyteletters
        /// Terminalescapecodes
        /// TrickUnicode
        /// TwoByteCharacters
        /// UnicodeNumbers
        /// UnicodeSubscriptSuperscriptAccents
        /// UnicodeSymbols
        /// UnicodeUpsidedown
        /// Unicodefont
        /// UnwantedInterpolation
        /// ZalgoText
        /// iOSVulnerabilities
        /// When null, the 'All' category is used.
        /// </summary></param>
        /// <returns></returns>
        public static RandomizerTextNaughtyStrings GenerateNaughtyStrings(string categories = null)
        {
            return new RandomizerTextNaughtyStrings(new FieldOptionsTextNaughtyStrings()
            {
                UseNullValues = false,
                ValueAsString = true,
                Seed = 2,
                Categories = categories
            });
        }


        /// <summary>
        /// Generate a new random password.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="charsetAvailables">The charset availables.</param>
        /// <returns></returns>
        public static string GeneratePassword(int length = 12, string charsetAvailables = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890&é'(-è_çà)=$ù%*µ,?;:/.?'")
        {

            if (length == 0)
                length = 12;

            var l = charsetAvailables.Length;

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--) res.Append(charsetAvailables[rnd.Next(l)]);

            return res.ToString();

        }



    }
}
