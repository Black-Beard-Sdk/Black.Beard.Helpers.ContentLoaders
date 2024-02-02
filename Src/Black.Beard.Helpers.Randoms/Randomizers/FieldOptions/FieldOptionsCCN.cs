using RandomDataGenerator.CreditCardValidator;

namespace RandomDataGenerator.FieldOptions;

/// <summary>
/// CCN Field Options
/// </summary>
/// <seealso cref="RandomDataGenerator.FieldOptions.FieldOptionsAbstract" />
/// <seealso cref="RandomDataGenerator.FieldOptions.IFieldOptionsString" />
public class FieldOptionsCCN : FieldOptionsAbstract, IFieldOptionsString
{

    /// <summary>
    /// Gets or sets the card issuer.
    /// </summary>
    /// <value>
    /// The card issuer.
    /// </value>
    public CardIssuer CardIssuer { get; set; } = CardIssuer.Visa;

    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    /// <value>
    /// The length.
    /// </value>
    public int Length { get; set; } = 0;

}