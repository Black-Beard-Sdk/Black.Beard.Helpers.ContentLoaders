namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// abstract class for number options
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsNumber&lt;T&gt;" />
    public abstract class FieldOptionsNumber<T> : FieldOptionsAbstract, IFieldOptionsNumber<T> where T : struct
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public virtual T Min { get; set; }

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public virtual T Max { get; set; }

    }


}