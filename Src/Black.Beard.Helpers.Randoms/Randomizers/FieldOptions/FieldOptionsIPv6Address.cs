
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// IPv6 Address Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsIPv6Address : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsIPv6Address"/> is uppercase.
        /// </summary>
        /// <value>
        ///   <c>true</c> if uppercase; otherwise, <c>false</c>.
        /// </value>
        public bool Uppercase { get; set; }

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