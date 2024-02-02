
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Guid Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsGuid" />
    public class FieldOptionsGuid : FieldOptionsAbstract, IFieldOptionsGuid
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FieldOptionsGuid"/> is uppercase.
        /// </summary>
        /// <value>
        ///   <c>true</c> if uppercase; otherwise, <c>false</c>.
        /// </value>
        public bool Uppercase { get; set; } = true;

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public string Format { get; set; } = "D";

    }
}