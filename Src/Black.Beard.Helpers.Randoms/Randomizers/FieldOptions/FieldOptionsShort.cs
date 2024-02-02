namespace RandomDataGenerator.FieldOptions
{
    /// <summary>
    /// Short Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Int16&gt;" />
    public class FieldOptionsShort : FieldOptionsNumber<short>
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override short Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override short Max { get; set; } = short.MaxValue;

    }
}