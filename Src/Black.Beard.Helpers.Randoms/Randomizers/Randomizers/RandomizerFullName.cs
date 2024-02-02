using System.Collections.Generic;
using RandomDataGenerator.Data;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Full name randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsFullName&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerFullName : RandomizerAbstract<FieldOptionsFullName>, IRandomizerString
{
    private readonly RandomThingsGenerator<int> _numberGenerator;
    private readonly RandomStringFromListGenerator _lastNamesGenerator;
    private readonly List<RandomStringFromListGenerator> _genderSetGenerators = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerFullName"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerFullName(FieldOptionsFullName options) : base(options)
    {
        _lastNamesGenerator = new RandomStringFromListGenerator(ListData.Instance.LastNames);

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
    /// Generates strings.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        int maleOrFemale = _numberGenerator.Generate();

        var firstNamesSet = _genderSetGenerators[maleOrFemale];
        string firstName = firstNamesSet.Generate()!;
        string lastname = _lastNamesGenerator.Generate()!;

        return $"{firstName} {lastname}";
    }

    /// <summary>
    /// Generates the strings
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}