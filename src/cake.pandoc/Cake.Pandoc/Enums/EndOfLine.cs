namespace Cake.Pandoc.Enums
{
    /// <summary>
    /// End of line.
    /// </summary>
    /// <seealso cref="Cake.Pandoc.Enums.EnumBaseType" />
    public class EndOfLine : EnumBaseType
    {
        /// <summary>
        /// rlf(Windows).
        /// </summary>
        public static readonly EndOfLine Rlf = new EndOfLine("rlf");

        /// <summary>
        /// lf(macOS/Linux/UNIX).
        /// </summary>
        public static readonly EndOfLine Lf = new EndOfLine("lf");

        /// <summary>
        /// native(line endings appropriate to the OS on which pandoc is being run).
        /// </summary>
        public static readonly EndOfLine Native = new EndOfLine("native");

        private EndOfLine(string value)
            : base(value)
        {
        }
    }
}
