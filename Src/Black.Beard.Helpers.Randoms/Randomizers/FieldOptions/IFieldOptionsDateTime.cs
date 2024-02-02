using System;

namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// 
    /// </summary>
    public interface IFieldOptionsDateTime
    {

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        DateTime From { get; set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        DateTime To { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [include time].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [include time]; otherwise, <c>false</c>.
        /// </value>
        bool IncludeTime { get; set; }

    }
}
