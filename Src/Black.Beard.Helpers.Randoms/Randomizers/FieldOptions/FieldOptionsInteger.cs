
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Integer field options.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Int32&gt;" />
    public class FieldOptionsInteger : FieldOptionsNumber<int>
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override int Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override int Max { get; set; } = int.MaxValue;

    }
}