using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Last name randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsLastName&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerLastName : RandomizerAbstract<FieldOptionsLastName>, IRandomizerString
{
    private readonly RandomStringFromListGenerator _lastNamesGenerator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerLastName"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerLastName(FieldOptionsLastName options) : base(options)
    {
        _lastNamesGenerator = new RandomStringFromListGenerator(ListData.Instance.LastNames);
    }

    /// <summary>
    /// Generates the last name as string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : _lastNamesGenerator.Generate();
    }

    /// <summary>
    /// Generates the last name as string.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}