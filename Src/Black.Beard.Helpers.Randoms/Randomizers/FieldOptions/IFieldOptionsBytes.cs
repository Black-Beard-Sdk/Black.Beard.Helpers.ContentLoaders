namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// 
    /// </summary>
    public interface IFieldOptionsBytes
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        int Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        int Max { get; set; }
    }
}