using System.Globalization;
using System.Linq;
using RandomDataGenerator.Extensions;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Mac address randomizer
/// </summary>
/// <seealso cref="RandomDataGenerator.Randomizers.RandomizerAbstract&lt;RandomDataGenerator.FieldOptions.FieldOptionsMACAddress&gt;" />
/// <seealso cref="RandomDataGenerator.Randomizers.IRandomizerString" />
public class RandomizerMACAddress : RandomizerAbstract<FieldOptionsMACAddress>, IRandomizerString
{
    private readonly byte[] _defaultMin = { 0, 0, 0, 0, 0, 0 };
    private readonly byte[] _defaultMax = { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
    private readonly RandomThingsGenerator<byte>[] _octets = new RandomThingsGenerator<byte>[6];

    /// <summary>
    /// Initializes a new instance of the <see cref="RandomizerMACAddress"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public RandomizerMACAddress(FieldOptionsMACAddress options) : base(options)
    {
        byte[] octetsMin = string.IsNullOrEmpty(Options.Min) ? _defaultMin : Options.Min!.Split(Options.Separator.First()).Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();
        byte[] octetsMax = string.IsNullOrEmpty(Options.Max) ? _defaultMax : Options.Max!.Split(Options.Separator.First()).Select(x => byte.Parse(x, NumberStyles.HexNumber)).ToArray();

        for (int i = 0; i < 6; i++)
        {
            _octets[i] = new RandomThingsGenerator<byte>(octetsMin[i], octetsMax[i], options.Seed);
        }
    }

    /// <summary>
    /// Generates the mac address.
    /// </summary>
    /// <returns></returns>
    public string? Generate()
    {
        return IsNull() ? null : GenerateInternal();
    }

    /// <summary>
    /// Generates the mac address
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    public string? Generate(bool upperCase)
    {
        return Generate().ToCasedInvariant(upperCase);
    }

    private string GenerateInternal()
    {
        var value = string.Join(Options.Separator, _octets.Select(gen => $"{gen.Generate():X2}").ToArray());

        return value.ToCasedInvariant(Options.Uppercase)!;
    }
}