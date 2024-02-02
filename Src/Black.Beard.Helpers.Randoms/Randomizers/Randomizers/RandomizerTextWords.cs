using System.Collections.Generic;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Text word
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsTextWords&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerTextWords : RandomizerAbstract<FieldOptionsTextWords>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;
    private readonly RandomValueGenerator _randomValueGenerator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerTextWords"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerTextWords(FieldOptionsTextWords options) : base(options)
    {
        _randomValueGenerator = RandomValueGeneratorFactory.Create(options.Seed);
        _generator = new RandomStringFromListGenerator(ListData.Instance.LoremIpsumWords, options.Seed);
    }

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int max = _randomValueGenerator.Next(Options.Min, Options.Max);
        var list = new List<string>(max);
        for (int i = 0; i < max; i++)
        {
            list.Add(_generator.Generate()!);
        }

        return string.Join(" ", list.ToArray());
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