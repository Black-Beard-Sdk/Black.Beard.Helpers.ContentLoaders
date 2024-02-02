
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// byte field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Byte&gt;" />
    public class FieldOptionsByte : FieldOptionsNumber<byte>
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override byte Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override byte Max { get; set; } = byte.MaxValue;

    }
}