using System;

namespace RandomDataGenerator.Randomizers;


/// <summary>
/// Timespan randomizer interface
/// </summary>
public interface IRandomizerTimeSpan
{

    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    TimeSpan? Generate();

    /// <summary>
    /// Generates as string.
    /// </summary>
    /// <returns></returns>
    string? GenerateAsString();

}