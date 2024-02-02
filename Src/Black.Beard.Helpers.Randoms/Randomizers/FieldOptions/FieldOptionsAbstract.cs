#if !NETSTANDARD1_3
using System.Xml.Serialization;
#endif

namespace RandomDataGenerator.FieldOptions
{

    /// <summary>
    /// Abstract class for field options
    /// </summary>
#if !NETSTANDARD1_3
    [XmlInclude(typeof(FieldOptionsBytes))]
    [XmlInclude(typeof(FieldOptionsCCN))]
    [XmlInclude(typeof(FieldOptionsCity))]
    [XmlInclude(typeof(FieldOptionsCountry))]
    [XmlInclude(typeof(FieldOptionsDateTime))]
    [XmlInclude(typeof(FieldOptionsEmailAddress))]
    [XmlInclude(typeof(FieldOptionsFirstName))]
    [XmlInclude(typeof(FieldOptionsIBAN))]
    [XmlInclude(typeof(FieldOptionsNumber<byte>))]
    [XmlInclude(typeof(FieldOptionsNumber<short>))]
    [XmlInclude(typeof(FieldOptionsNumber<int>))]
    [XmlInclude(typeof(FieldOptionsNumber<long>))]
    [XmlInclude(typeof(FieldOptionsNumber<float>))]
    [XmlInclude(typeof(FieldOptionsNumber<double>))]
    [XmlInclude(typeof(FieldOptionsFullName))]
    [XmlInclude(typeof(FieldOptionsGuid))]
    [XmlInclude(typeof(FieldOptionsInteger))]
    [XmlInclude(typeof(FieldOptionsIPv4Address))]
    [XmlInclude(typeof(FieldOptionsIPv6Address))]
    [XmlInclude(typeof(FieldOptionsLastName))]
    [XmlInclude(typeof(FieldOptionsMACAddress))]
    [XmlInclude(typeof(FieldOptionsTextRegex))]
    [XmlInclude(typeof(FieldOptionsTextNaughtyStrings))]
    [XmlInclude(typeof(FieldOptionsText))]
    [XmlInclude(typeof(FieldOptionsTextWords))]
    [XmlInclude(typeof(FieldOptionsStringList))]
#endif
    public abstract class FieldOptionsAbstract
    {
        /// <summary>
        /// Gets or sets a value indicating whether [use null values].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use null values]; otherwise, <c>false</c>.
        /// </value>
        public bool UseNullValues { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [value as string].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [value as string]; otherwise, <c>false</c>.
        /// </value>
        public bool ValueAsString { get; set; }

        /// <summary>
        /// Gets or sets the seed.
        /// </summary>
        /// <value>
        /// The seed.
        /// </value>
        public int? Seed { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public FieldOptionsAbstract Clone()
        {
            return (FieldOptionsAbstract)MemberwiseClone();
        }
    }
}