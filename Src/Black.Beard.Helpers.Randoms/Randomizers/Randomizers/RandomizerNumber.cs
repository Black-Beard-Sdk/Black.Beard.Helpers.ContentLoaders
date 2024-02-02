using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Number randomizer
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;T&gt;&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerNumber&lt;T&gt;" />
public class RandomizerNumber<T> : RandomizerAbstract<FieldOptionsNumber<T>>, IRandomizerNumber<T> where T : struct
{
    private readonly RandomThingsGenerator<T> _generator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerNumber{T}"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerNumber(FieldOptionsNumber<T> options) : base(options)
    {
        _generator = new RandomThingsGenerator<T>(options.Min, options.Max, options.Seed);
    }

    /// <summary>
    /// Generates value.
    /// </summary>
    /// <returns></returns>
    public T? Generate()
    {
        return IsNull() ? null : (T?)_generator.Generate();
    }
}