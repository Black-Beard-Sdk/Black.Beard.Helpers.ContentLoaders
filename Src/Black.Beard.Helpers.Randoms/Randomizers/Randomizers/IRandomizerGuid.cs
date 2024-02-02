using System;

namespace RandomDataGenerator.Randomizers;

/// <summary>
/// Guid randomizer interface
/// </summary>
public interface IRandomizerGuid
{
    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    Guid? Generate();

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <returns></returns>
    string? GenerateAsString();

}