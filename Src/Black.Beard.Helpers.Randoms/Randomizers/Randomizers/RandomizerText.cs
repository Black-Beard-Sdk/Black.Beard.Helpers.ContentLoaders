using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;


/// <summary>
/// Text randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsText&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerText : RandomizerAbstract<FieldOptionsText>, IRandomizerString
{
    private readonly RandomStringGenerator _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerText"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerText(FieldOptionsText options)
        : base(options)
    {
        _generator = new RandomStringGenerator(options.Seed, options.UseUppercase, options.UseLowercase, options.UseNumber, options.UseSpecial, options.UseSpace);
    }

    /// <summary>
    /// Generates the text.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : _generator.Generate(Options.Min, Options.Max);
    }

    /// <summary>
    /// Generates the text in upper case.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}