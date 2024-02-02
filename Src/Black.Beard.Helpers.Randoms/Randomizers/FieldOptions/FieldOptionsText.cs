
namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Text randomize context Enumeration
    /// </summary>
    [Flags]
    public enum TextRandomizeContextEnum
    {

        /// <summary>
        /// Use letter
        /// </summary>
        UseLetter,

        /// <summary>
        /// Use number
        /// </summary>
        UseNumber,

        /// <summary>
        /// Use space
        /// </summary>
        UseSpace,

        /// <summary>
        /// Use lowercase
        /// </summary>
        UseLowercase,

        /// <summary>
        /// Use uppercase
        /// </summary>
        UseUppercase,

        /// <summary>
        /// Use special
        /// </summary>
        UseSpecial,

        /// <summary>
        /// Use All
        /// </summary>
        All = UseLetter | UseNumber | UseSpace | UseLowercase | UseUppercase | UseSpecial,
    }

    /// <summary>
    /// Text randomizer options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsText : FieldOptionsAbstract, IFieldOptionsString
    {

        /// <summary>
        /// Determines the minimum value to generate.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public int Min { get; set; } = 8;

        /// <summary>
        /// Determines the maximum value to generate.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        public int Max { get; set; } = 8;

        /// <summary>
        /// Gets or sets a value indicating whether [use uppercase].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use uppercase]; otherwise, <c>false</c>.
        /// </value>
        public bool UseUppercase { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [use lowercase].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use lowercase]; otherwise, <c>false</c>.
        /// </value>
        public bool UseLowercase { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [use letter].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use letter]; otherwise, <c>false</c>.
        /// </value>
        public bool UseLetter { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [use number].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use number]; otherwise, <c>false</c>.
        /// </value>
        public bool UseNumber { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [use space].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use space]; otherwise, <c>false</c>.
        /// </value>
        public bool UseSpace { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [use special].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use special]; otherwise, <c>false</c>.
        /// </value>
        public bool UseSpecial { get; set; } = true;

    }
}