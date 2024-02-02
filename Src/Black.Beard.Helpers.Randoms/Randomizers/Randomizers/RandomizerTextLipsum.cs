using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Lipsum text randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsTextLipsum&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerTextLipsum : RandomizerAbstract<FieldOptionsTextLipsum>, IRandomizerString
{
    private const string Newline = "\r\n";
    private readonly RandomStringsFromListGenerator _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerTextLipsum"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerTextLipsum(FieldOptionsTextLipsum options) : base(options)
    {
        _generator = new RandomStringsFromListGenerator(ListData.Instance.LoremIpsum);
    }


    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : string.Join(Newline, _generator.Generate(Options.Paragraphs).ToArray());
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