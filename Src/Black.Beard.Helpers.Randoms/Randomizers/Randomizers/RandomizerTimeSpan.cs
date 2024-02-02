using System;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Randomizer that generates TimeSpan
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsTimeSpan&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerTimeSpan" />
public class RandomizerTimeSpan : RandomizerAbstract<FieldOptionsTimeSpan>, IRandomizerTimeSpan
{
    private readonly RandomThingsGenerator<TimeSpan> _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerTimeSpan"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerTimeSpan(FieldOptionsTimeSpan options) : base(options)
    {
        _generator = new RandomThingsGenerator<TimeSpan>(options.From, options.To, options.Seed);
    }

    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    public TimeSpan? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        var ts = _generator.Generate();

        return Options.IncludeMilliseconds ? ts : new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
    }

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <returns></returns>
    public string? GenerateAsString()
    {
        TimeSpan? ts = Generate();

        string format = !string.IsNullOrEmpty(Options.Format) ? Options.Format : FieldOptionsTimeSpan.DefaultFormat;
        return ts != null ? string.Format($"{{0:{format}}}", ts) : null;
    }

}