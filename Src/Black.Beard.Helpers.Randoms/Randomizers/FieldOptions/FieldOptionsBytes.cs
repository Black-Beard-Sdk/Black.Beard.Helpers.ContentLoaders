
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Bytes field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsBytes" />
    public class FieldOptionsBytes : FieldOptionsAbstract, IFieldOptionsBytes
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public int Min { get; set; }

        /// <summary>
        /// Determines the maximum  value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public int Max { get; set; } = 1024;
    }
}