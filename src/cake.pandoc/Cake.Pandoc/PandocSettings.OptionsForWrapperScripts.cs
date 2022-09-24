using System.Runtime.Serialization;

// https://pandoc.org/MANUAL.html#options-for-wrapper-scripts

namespace Cake.Pandoc
{
    public partial class PandocSettings
    {
        /// <summary>
        /// Print information about command-line arguments to stdout, then exit.
        /// </summary>
        [DataMember(Name = "dump-args")]
        public bool DumpArgs { get; set; }

        /// <summary>
        /// Ignore command-line arguments.
        /// </summary>
        [DataMember(Name = "ignore-args")]
        public bool IgnoreArgs { get; set; }
    }
}
