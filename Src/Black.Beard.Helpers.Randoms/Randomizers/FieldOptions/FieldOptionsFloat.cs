
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Float Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Single&gt;" />
    public class FieldOptionsFloat : FieldOptionsNumber<float>
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override float Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override float Max { get; set; } = float.MaxValue;

    }
}