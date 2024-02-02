namespace RandomDataGenerator.Randomizers;

/// <summary>
/// string randomizer interface
/// </summary>
public interface IRandomizerString
{

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <returns></returns>
    string? Generate();

    /// <summary>
    /// Generates the value string.
    /// </summary>
    /// <param name="upperCase">if set to <c>true</c> [upper case].</param>
    /// <returns></returns>
    string? Generate(bool upperCase);


}