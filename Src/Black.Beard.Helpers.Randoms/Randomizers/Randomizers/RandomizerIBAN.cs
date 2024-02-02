using System;
using System.Linq;
using RandomDataGenerator.Data;
using RandomDataGenerator.Data.Models;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Ibans randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsIBAN&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerIBAN : RandomizerAbstract<FieldOptionsIBAN>, IRandomizerString
{
    private readonly RandomItemFromListGenerator<IBAN> _itemGenerator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerIBAN"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerIBAN(FieldOptionsIBAN options) : base(options)
    {
        Func<IBAN, bool>? predicate = null;

        if (!string.IsNullOrEmpty(options.CountryCode))
        {
            predicate = iban => iban.CountryCode == options.CountryCode;
        }

        // Set the list to IBAN as default
        var list = ListData.Instance.IBANs; 
        switch (options.Type)
        {
            case "BBAN":
                list = ListData.Instance.BBANs;
                break;

            case "BOTH":
                list = list.Union(ListData.Instance.BBANs);
                break;
        }

        _itemGenerator = new RandomItemFromListGenerator<IBAN>(options.Seed, list, predicate);
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

        var iban = _itemGenerator.Generate();
        return iban.Generator.Generate();
    }

    /// <summary>
    /// Generates the specified upper case.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }

}