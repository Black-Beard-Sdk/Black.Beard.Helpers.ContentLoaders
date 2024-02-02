using System.Collections.Generic;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// First name randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsFirstName&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerFirstName : RandomizerAbstract<FieldOptionsFirstName>, IRandomizerString
{
    private readonly RandomThingsGenerator<int> _numberGenerator;
    private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new List<RandomStringFromListGenerator>();

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerFirstName"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerFirstName(FieldOptionsFirstName options) : base(options)
    {
        if (options.Male)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.MaleNames));
        }

        if (options.Female)
        {
            _genderSetGenerators.Add(new RandomStringFromListGenerator(ListData.Instance.FemaleNames));
        }

        _numberGenerator = new RandomThingsGenerator<int>(0, _genderSetGenerators.Count, options.Seed);
    }

    /// <summary>
    /// Generates the string.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int maleOrFemale = _numberGenerator.Generate();

        return _genderSetGenerators[maleOrFemale].Generate();
    }

    /// <summary>
    /// Generates the string.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}