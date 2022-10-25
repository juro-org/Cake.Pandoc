namespace Cake.Pandoc.Enums
{
    /// <summary>
    /// Base class for enum style type settings.
    /// </summary>
    public class EnumBaseType
    {
        private string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumBaseType"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public EnumBaseType(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.value;
        }
    }
}
