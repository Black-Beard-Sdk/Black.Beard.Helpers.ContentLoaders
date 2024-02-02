using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// string list randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsStringList&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerStringList : RandomizerAbstract<FieldOptionsStringList>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerStringList"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerStringList(FieldOptionsStringList options)
        : base(options)
    {
        _generator = new RandomStringFromListGenerator(options.Values);
    }

    /// <summary>
    /// select an item in the source list
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : _generator.Generate();
    }

    /// <summary>
    /// select an item in the source list
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return IsNull() ? null : _generator.Generate().ToCasedInvariant(upperCase);
    }
}