using System.Collections.Generic;

namespace RandomDataGenerator.FieldOptions;

/// <summary>
/// String List Field options class
/// </summary>
/// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
/// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
public class FieldOptionsStringList : FieldOptionsAbstract, IFieldOptionsString
{

    /// <summary>
    /// Gets or sets the values.
    /// </summary>
    /// <value>
    /// The values.
    /// </value>
    public IEnumerable<string> Values { get; set; }

}