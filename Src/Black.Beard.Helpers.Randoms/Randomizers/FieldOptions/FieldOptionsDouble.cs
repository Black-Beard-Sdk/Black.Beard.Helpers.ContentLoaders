
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Double Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsNumber&lt;System.Double&gt;" />
    public class FieldOptionsDouble : FieldOptionsNumber<double>
    {
        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public override double Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public override double Max { get; set; } = double.MaxValue;
    }

  
}