
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Long field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Int64&gt;" />
    public class FieldOptionsLong : FieldOptionsNumber<long>
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override long Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override long Max { get; set; } = long.MaxValue;

    }
}