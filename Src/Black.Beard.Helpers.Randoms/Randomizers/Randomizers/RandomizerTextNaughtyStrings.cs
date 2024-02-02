using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Naughty strings randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsTextNaughtyStrings&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerTextNaughtyStrings : RandomizerAbstract<FieldOptionsTextNaughtyStrings>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _naughtyStringCategoryGenerator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerTextNaughtyStrings"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerTextNaughtyStrings(FieldOptionsTextNaughtyStrings options) : base(options)
    {
        Type type = typeof(TheNaughtyStrings);

        var allStrings = new List<string>(TheNaughtyStrings.All);

        var categories = options.Categories
            .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .Where(s => s != FieldOptionsTextNaughtyStrings.All);
        foreach (string category in categories)
        {
            if (type.GetField(category).GetValue(null) is IList<string> strings)
            {
                allStrings.AddRange(strings);
            }
        }

        _naughtyStringCategoryGenerator = new RandomStringFromListGenerator(allStrings);
    }

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : _naughtyStringCategoryGenerator.Generate();
    }

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}