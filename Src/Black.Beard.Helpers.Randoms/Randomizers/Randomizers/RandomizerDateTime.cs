using System;
using System.Globalization;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;


/// <summary>
/// DateTime randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsDateTime&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerDateTime" />
public class RandomizerDateTime : RandomizerAbstract<FieldOptionsDateTime>, IRandomizerDateTime
{
    private readonly RandomThingsGenerator<DateTime> _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerDateTime"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerDateTime(FieldOptionsDateTime options)
        : base(options)
    {
        _generator = new RandomThingsGenerator<DateTime>(options.From, options.To, options.Seed);
    }

    /// <summary>
    /// Generates the dateTime.
    /// </summary>
    /// <returns></returns>
    public DateTime? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        DateTime value = _generator.Generate();
        return Options.IncludeTime ? value : value.Date;
    }

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <returns></returns>
    public string? GenerateAsString()
    {
        DateTime? date = Generate();

        string format = !string.IsNullOrEmpty(Options.Format) ? Options.Format : FieldOptionsDateTime.DefaultFormat;
        return date?.ToString(format, CultureInfo.InvariantCulture);
    }
}