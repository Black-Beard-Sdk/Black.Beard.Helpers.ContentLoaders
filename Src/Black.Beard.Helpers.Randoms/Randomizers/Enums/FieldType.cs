using System.ComponentModel;

namespace RandomDataGenerator.Enums
{

    /// <summary>
    /// Type of field
    /// </summary>
    public enum FieldType
    {

        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// Numbers
        /// </summary>
        [Description("Numbers")]
        Numbers,

        /// <summary>
        /// IT
        /// </summary>
        [Description("IT")]
        IT,

        /// <summary>
        /// Human
        /// </summary>
        [Description("Human")]
        Human,

        /// <summary>
        /// Location
        /// </summary>
        [Description("Location")]
        Location,

        /// <summary>
        /// Text
        /// </summary>
        [Description("Text")]
        Text,

        /// <summary>
        /// Time
        /// </summary>
        [Description("Time")]
        Time,

        /// <summary>
        /// Set
        /// </summary>
        [Description("Set")]
        Set
    }
}