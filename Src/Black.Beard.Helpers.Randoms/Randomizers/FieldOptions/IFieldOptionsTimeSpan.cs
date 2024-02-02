using System;

namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Timespan field options interface
    /// </summary>
    public interface IFieldOptionsTimeSpan
    {

        /// <summary>
        /// Allowed values are "c", "g" and "G".
        /// See https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings
        /// </summary>
        string Format { get; set; }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        TimeSpan From { get; set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        TimeSpan To { get; set; }

    }
}
