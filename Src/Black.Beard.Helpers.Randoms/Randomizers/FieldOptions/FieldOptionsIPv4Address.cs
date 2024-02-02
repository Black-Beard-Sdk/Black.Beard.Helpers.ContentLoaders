
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Ip v4 address field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsIPv4Address : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public string? Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public string? Max { get; set; }

    }
}