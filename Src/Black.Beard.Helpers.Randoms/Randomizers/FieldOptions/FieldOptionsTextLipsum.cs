
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// TextLipsum field options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsTextLipsum : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Gets or sets the paragraphs count
        /// </summary>
        /// <value>
        /// The paragraphs.
        /// </value>
        public int Paragraphs { get; set; } = 1;
    }
}