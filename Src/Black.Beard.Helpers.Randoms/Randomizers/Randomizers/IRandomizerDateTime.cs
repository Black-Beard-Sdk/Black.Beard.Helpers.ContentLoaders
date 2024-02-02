using System;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// DateTime randomizer interface
/// </summary>
public interface IRandomizerDateTime
{

    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    DateTime? Generate();

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <returns></returns>
    string? GenerateAsString();

}