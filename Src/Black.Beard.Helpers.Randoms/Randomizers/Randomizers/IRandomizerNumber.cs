namespace RandomDataGenerator.Randomizers;


/// <summary>
/// number randomizer interface
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRandomizerNumber<T> where T : struct
{

    /// <summary>
    /// Generates this instance.
    /// </summary>
    /// <returns></returns>
    T? Generate();

}