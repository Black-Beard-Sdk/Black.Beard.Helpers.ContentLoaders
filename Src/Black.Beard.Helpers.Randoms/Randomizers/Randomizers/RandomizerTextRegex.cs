using System;
using Fare;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Regex text randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsTextRegex&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerTextRegex : RandomizerAbstract<FieldOptionsTextRegex>, IRandomizerString
{
    private readonly Xeger _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerTextRegex"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerTextRegex(FieldOptionsTextRegex options) : base(options)
    {
        _generator = options.Seed.HasValue ? new Xeger(options.Pattern, new Random(options.Seed.Value)) : new Xeger(options.Pattern);
    }

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() || string.IsNullOrEmpty(Options.Pattern) ? null : _generator.Generate();
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