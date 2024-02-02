using System;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Guid randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsGuid&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerGuid" />
public class RandomizerGuid : RandomizerAbstract<FieldOptionsGuid>, IRandomizerGuid
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerGuid"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerGuid(FieldOptionsGuid options) : base(options)
    {
    }

    /// <summary>
    /// Generates the guid.
    /// </summary>
    /// <returns></returns>
    public Guid? Generate()
    {
        if (IsNull())
        {
            return null;
        }

        return Guid.NewGuid();
    }

    /// <summary>
    /// Generates the guid as string.
    /// </summary>
    /// <returns></returns>
    public string? GenerateAsString()
    {
        return IsNull() ? null : Guid.NewGuid().ToString(Options.Format).ToCasedInvariant(Options.Uppercase);
    }
}