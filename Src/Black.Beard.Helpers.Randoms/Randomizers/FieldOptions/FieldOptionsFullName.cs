
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Full name options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsFullName : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsFullName"/> is male.
        /// </summary>
        /// <value>
        ///   <c>true</c> if male; otherwise, <c>false</c>.
        /// </value>
        public bool Male { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsFullName"/> is female.
        /// </summary>
        /// <value>
        ///   <c>true</c> if female; otherwise, <c>false</c>.
        /// </value>
        public bool Female { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [left2 right].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [left2 right]; otherwise, <c>false</c>.
        /// </value>
        public bool Left2Right { get; set; } = true;
    }
}