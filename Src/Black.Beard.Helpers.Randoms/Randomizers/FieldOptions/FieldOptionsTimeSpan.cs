using System;

namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsTimeSpan" />
    public class FieldOptionsTimeSpan : FieldOptionsAbstract, IFieldOptionsTimeSpan
    {

        /// <summary>
        /// The default format
        /// </summary>
        public const string DefaultFormat = "c"; // "c" -> Constant (invariant) format


        /// <summary>
        /// Allowed values are "c", "g" and "G".
        /// See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings
        /// </summary>
        public string Format { get; set; } = DefaultFormat;


        /// <summary>
        /// Gets or sets a value indicating whether [include milliseconds].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include milliseconds]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludeMilliseconds { get; set; } = true;

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public TimeSpan From { get; set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public TimeSpan To { get; set; } = TimeSpan.MaxValue;

    }
}