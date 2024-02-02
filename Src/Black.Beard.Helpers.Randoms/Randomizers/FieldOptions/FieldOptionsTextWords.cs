
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// TextWords field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsTextWords : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public int Min { get; set; } = 1;

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public int Max { get; set; } = 10;

    }
}