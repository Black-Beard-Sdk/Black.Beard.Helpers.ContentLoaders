
namespace RandomDataGenerator.FieldOptions
{
    /// <summary>
    /// Ibans are used to identify individual bank accounts for both incoming and outgoing international money transfer.
    /// </summary>
    /// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
    /// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
    public class FieldOptionsIBAN : FieldOptionsAbstract, IFieldOptionsString
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string? CountryCode { get; set; }

        /// <summary>
        /// The type can be IBAN (default), BBAN or BOTH. In case the value is null, IBAN is used as default.
        /// </summary>
        public string Type { get; set; } = "IBAN";
    }
}