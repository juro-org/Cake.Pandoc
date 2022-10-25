/*
 * MIT License
 *
 * Copyright (c) 2022 Jürgen Rosenthal-Buroh
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

// https://pandoc.org/MANUAL.html#general-options

namespace Cake.Pandoc
{
    using Cake.Core.IO;
    using System.Runtime.Serialization;

    public sealed partial class PandocSettings
    {
        /// <summary>
        /// Specify input format
        /// Extensions can be individually enabled or disabled by appending +EXTENSION or -EXTENSION to the format name.
        /// </summary>
        [DataMember(Name = "from")]
        public Enums.From From { get; set; }

        /// <summary>
        /// Specify output format
        /// Extensions can be individually enabled or disabled by appending +EXTENSION or -EXTENSION to the format name.
        /// </summary>
        [DataMember(Name = "to")]
        public Enums.To To { get; set; }

        /// <summary>
        /// Write output to FILE instead of stdout.If FILE is -, output will go to stdout, even if a non-textual format (docx, odt, epub2, epub3) is specified.
        /// </summary>
        [DataMember(Name = "output")]
        public FilePath Output { get; set; }

        /// <summary>
        /// Specify the user data directory to search for pandoc data files.If this option is not specified, the default user data directory will be used.
        /// </summary>
        [DataMember(Name = "data-dir")]
        public DirectoryPath DataDirectory { get; set; }

        /// <summary>
        /// Specify a set of default option settings.
        /// </summary>
        [DataMember(Name = "defaults")]
        public FilePath Defaults { get; set; }

        /// <summary>
        /// Generate a bash completion script. To enable bash completion with pandoc, add this to your .bashrc:.
        /// </summary>
        [DataMember(Name = "bash-completion")]
        public bool BashCompletion { get; set; }

        /// <summary>
        /// Give verbose debugging output.
        /// </summary>
        [DataMember(Name = "verbose")]
        public bool Verbose { get; set; }

        /// <summary>
        /// Suppress warning messages.
        /// </summary>
        [DataMember(Name = "quiet")]
        public bool Quiet { get; set; }

        /// <summary>
        /// Exit with error status if there are any warnings.
        /// </summary>
        [DataMember(Name = "fail-if-warnings")]
        public bool FailIfWarnings { get; set; }

        /// <summary>
        /// Write log messages in machine-readable JSON format to FILE.All messages above DEBUG level will be written, regardless of verbosity settings (--verbose, --quiet).
        /// </summary>
        [DataMember(Name = "log")]
        public string Log { get; set; }

        /// <summary>
        /// List supported input formats, one per line.
        /// </summary>
        [DataMember(Name = "list-input-formats")]
        public bool ListInputFormats { get; set; }

        /// <summary>
        /// List supported output formats, one per line.
        /// </summary>
        [DataMember(Name = "list-output-formats")]
        public bool ListOutputFormats { get; set; }

        /// <summary>
        /// List supported extensions for FORMAT, one per line, preceded by a + or - indicating whether it is enabled by default in FORMAT.If FORMAT is not specified, defaults for pandoc’s Markdown are given.
        /// </summary>
        [DataMember(Name = "list-extensions")]
        public string ListExtensions { get; set; }

        /// <summary>
        /// List supported languages for syntax highlighting, one per line.
        /// </summary>
        [DataMember(Name = "list-highlight-languages")]
        public bool ListHighlightLanguages { get; set; }

        /// <summary>
        /// List supported styles for syntax highlighting, one per line.
        /// </summary>
        [DataMember(Name = "list-highlight-styles")]
        public bool ListHighlightStyles { get; set; }

        /// <summary>
        /// Print version.
        /// </summary>
        [DataMember(Name = "version")]
        public bool Version { get; set; }

        /// <summary>
        /// Show usage message.
        /// </summary>
        [DataMember(Name = "help")]
        public bool Help { get; set; }
    }
}
