using System.ComponentModel;

namespace RandomDataGenerator.Enums
{

    /// <summary>
    /// 
    /// </summary>
    public enum SubFieldType
    {

        /// <summary>
        /// The none option
        /// </summary>
        None,

        // Numbers

        /// <summary>
        /// Boolean
        /// </summary>
        [Description("Boolean")]
        Boolean,

        /// <summary>
        /// Short
        /// </summary>
        [Description("Short")]
        Short,

        /// <summary>
        /// Integer
        /// </summary>
        [Description("Integer")]
        Integer,

        /// <summary>
        /// Long
        /// </summary>
        [Description("Long")]
        Long,

        /// <summary>
        /// Float
        /// </summary>
        [Description("Float")]
        Float,

        /// <summary>
        /// Double
        /// </summary>
        [Description("Double")]
        Double,

        /// <summary>
        /// CCN payment card
        /// </summary>
        [Description("CCN")]
        CCN,


        // IT
        /// <summary>
        /// IPv4 Address
        /// </summary>
        [Description("IPv4 Address")]
        IPv4Address,

        /// <summary>
        /// IPV6 Address
        /// </summary>
        [Description("IPv6 Address")]
        IPv6Address,

        /// <summary>
        /// Mac Address
        /// </summary>
        [Description("MAC Address")]
        MACAddress,

        /// <summary>
        /// Guid
        /// </summary>
        [Description("Guid")]
        Guid,


        // Human
        /// <summary>
        /// Full Name
        /// </summary>
        [Description("Full Name")]
        FullName,

        /// <summary>
        /// Last Name
        /// </summary>
        [Description("Last Name")]
        LastName,

        /// <summary>
        /// First Name
        /// </summary>
        [Description("First Name")]
        FirstName,

        /// <summary>
        /// Email Address
        /// </summary>
        [Description("Email Address")]
        EmailAddress,


        // Location
        /// <summary>
        /// Country
        /// </summary>
        [Description("Country")]
        Country,

        /// <summary>
        /// City
        /// </summary>
        [Description("City")]
        City,


        // Text
        /// <summary>
        /// Text words
        /// </summary>
        [Description("Words")]
        TextWords,

        /// <summary>
        /// Text pattern
        /// </summary>
        [Description("Text Pattern")]
        TextPattern,

        /// <summary>
        /// Regex
        /// </summary>
        [Description("Text Regex")]
        TextRegex,

        /// <summary>
        /// Lipsum
        /// </summary>
        [Description("Text Lipsum")]
        TextLipsum,

        /// <summary>
        /// Text
        /// </summary>
        [Description("Random Text")]
        Text,

        /// <summary>
        /// Naughty Strings
        /// </summary>
        [Description("Naughty Strings")]
        TextNaughtyStrings,

        /// <summary>
        /// Date / Time
        /// </summary>
        [Description("Date / Time")]
        DateTime,


        // Set
        /// <summary>
        /// string list
        /// </summary>
        [Description("String List")]
        StringList
    }
}