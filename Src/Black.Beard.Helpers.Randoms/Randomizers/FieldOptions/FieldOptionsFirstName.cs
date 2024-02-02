namespace RandomDataGenerator.FieldOptions
{
    /// <summary>
    /// First name options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsFirstName : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsFirstName"/> is male.
        /// </summary>
        /// <value>
        ///   <c>true</c> if male; otherwise, <c>false</c>.
        /// </value>
        public bool Male { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsFirstName"/> is female.
        /// </summary>
        /// <value>
        ///   <c>true</c> if female; otherwise, <c>false</c>.
        /// </value>
        public bool Female { get; set; } = true;
    }
}