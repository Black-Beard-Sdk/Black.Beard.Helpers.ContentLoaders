using System.Text;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Bytes randomizer interface
/// </summary>
public interface IRandomizerBytes
{

    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    byte[] Generate();

    /// <summary>
    /// Generates as ut f8 string.
    /// </summary>
    /// <returns></returns>
    string GenerateAsUTF8String();

    /// <summary>
    /// Generates as ASCII string.
    /// </summary>
    /// <returns></returns>
    string GenerateAsASCIIString();

    /// <summary>
    /// Generates as base64 string.
    /// </summary>
    /// <returns></returns>
    string GenerateAsBase64String();

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <param name="encoding">The encoding.</param>
    /// <returns></returns>
    string GenerateAsString(Encoding? encoding = null);

}