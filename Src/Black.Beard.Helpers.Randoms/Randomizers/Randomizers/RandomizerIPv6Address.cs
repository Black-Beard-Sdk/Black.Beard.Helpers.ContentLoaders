using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;


/// <summary>
/// IP v6 address randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsIPv6Address&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerIPv6Address : RandomizerAbstract<FieldOptionsIPv6Address>, IRandomizerString
{
    private readonly int[] _defaultMin = { 0, 0, 0, 0, 0, 0, 0, 0 };
    private readonly int[] _defaultMax = { 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff, 0xffff };

    private readonly RandomThingsGenerator<int>[] _hextets = new RandomThingsGenerator<int>[8];

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerIPv6Address"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerIPv6Address(FieldOptionsIPv6Address options) : base(options)
    {
        int[] hextetsMin = string.IsNullOrEmpty(Options.Min) ? _defaultMin : Options.Min!.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();
        int[] hextetsMax = string.IsNullOrEmpty(Options.Max) ? _defaultMax : Options.Max!.Split(':').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();

        for (int i = 0; i < 8; i++)
        {
            _hextets[i] = new RandomThingsGenerator<int>(hextetsMin[i], hextetsMax[i], options.Seed);
        }
    }

    /// <summary>
    /// Generates ip v6 address as string
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : string.Join(":", _hextets.Select(gen => $"{gen.Generate():X4}").ToArray());
    }

    /// <summary>
    /// Generates ip v6 address as string
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }
}