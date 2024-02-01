using System.Collections.Generic;

namespace RandomDataGenerator.FieldOptions;

public class FieldOptionsStringList : FieldOptionsAbstract, IFieldOptionsString
{
    public IEnumerable<string> Values { get; set; }

}