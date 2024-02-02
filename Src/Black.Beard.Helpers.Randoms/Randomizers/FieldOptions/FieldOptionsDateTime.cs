using System;

namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// DateTime field options
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsDateTime" />
    public class FieldOptionsDateTime : FieldOptionsAbstract, IFieldOptionsDateTime
    {

        /// <summary>
        /// The default format
        /// </summary>
        public const string DefaultFormat = "s"; // "s" -> sortable date/time pattern


        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>
        /// The format.
        /// </value>
        public string Format { get; set; } = DefaultFormat;

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public DateTime From { get; set; } = DateTime.UtcNow.Date;

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public DateTime To { get; set; } = DateTime.UtcNow.Date.AddYears(1);

        /// <summary>
        /// Gets or sets a value indicating whether [include time].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include time]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeTime { get; set; } = true;

    }

}