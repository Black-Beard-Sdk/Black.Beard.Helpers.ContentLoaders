namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// TextRegex Field Options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsTextRegex : FieldOptionsAbstract, IFieldOptionsString
    {
        /// <summary>
        /// Use any valid Regex pattern to generate a string.
        /// </summary>
        public string Pattern { get; set; } = null!;
    }
}