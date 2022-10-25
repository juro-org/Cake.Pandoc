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

// https://pandoc.org/MANUAL.html#reader-options

namespace Cake.Pandoc
{
    using System.Runtime.Serialization;

    public partial class PandocSettings
    {
        /// <summary>
        /// Shift heading levels by a positive or negative integer.For example, with --shift-heading-level-by= -1, level 2 headings become level 1 headings, and level 3 headings become level 2 headings.Headings cannot have a level less than 1, so a heading that would be shifted below level 1 becomes a regular paragraph. Exception: with a shift of -N, a level-N heading at the beginning of the document replaces the metadata title. --shift-heading-level-by= -1 is a good choice when converting HTML or Markdown documents that use an initial level-1 heading for the document title and level-2+ headings for sections. --shift-heading-level-by= 1 may be a good choice for converting Markdown documents that use level-1 headings for sections to HTML, since pandoc uses a level-1 heading to render the document title.
        /// </summary>
        [DataMember(Name = "shift-heading-level-b")]
        public string ShiftHeadingLevelB { get; set; }

        /// <summary>
        /// Deprecated.Use --shift-heading-level-by= X instead, where X = NUMBER - 1.Specify the base level for headings (defaults to 1).
        /// </summary>
        [DataMember(Name = "base-header-level")]
        public string BaseHeaderLevel { get; set; }

        /// <summary>
        /// Deprecated.Use the +empty_paragraphs extension instead.Ignore paragraphs with no content.This option is useful for converting word processing documents where users have used empty paragraphs to create inter-paragraph space.
        /// </summary>
        [DataMember(Name = "strip-empty-paragraphs")]
        public bool StripEmptyParagraphs { get; set; }

        /// <summary>
        /// Specify classes to use for indented code blocks–for example, perl, numberLines or haskell.Multiple classes may be separated by spaces or commas.
        /// </summary>
        [DataMember(Name = "indented-code-classe")]
        public string IndentedCodeClasse { get; set; }

        /// <summary>
        /// Specify a default extension to use when image paths/URLs have no extension. This allows you to use the same source for formats that require different kinds of images.Currently this option only affects the Markdown and LaTeX readers.
        /// </summary>
        [DataMember(Name = "default-image-extension")]
        public string DefaultImageExtension { get; set; }

        /// <summary>
        /// Parse each file individually before combining for multifile documents. This will allow footnotes in different files with the same identifiers to work as expected.If this option is set, footnotes and links will not work across files. Reading binary files (docx, odt, epub) implies --file-scope.
        /// </summary>
        [DataMember(Name = "file-scope")]
        public bool FileScope { get; set; }

        /// <summary>
        /// Specify an executable to be used as a filter transforming the pandoc AST after the input is parsed and before the output is written.
        /// </summary>
        [DataMember(Name = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Transform the document in a similar fashion as JSON filters(see --filter), but use pandoc’s built-in Lua filtering system.
        /// </summary>
        [DataMember(Name = "lua-filter")]
        public string LuaFilter { get; set; }

        /// <summary>
        ///  Set the metadata field KEY to the value VAL.A value specified on the command line overrides a value specified in the document using YAML metadata blocks.
        /// </summary>
        [DataMember(Name = "metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// Read metadata from the supplied YAML(or JSON) file.This option can be used with every input format, but string scalars in the YAML file will always be parsed as Markdown.
        /// </summary>
        [DataMember(Name = "metadata-filee")]
        public string MetadataFile { get; set; }

        /// <summary>
        /// Preserve tabs instead of converting them to spaces. (By default, pandoc converts tabs to spaces before parsing its input.)
        /// </summary>
        [DataMember(Name = "preserve-tabs")]
        public bool PreserveTabs { get; set; }

        /// <summary>
        /// Specify the number of spaces per tab (default is 4).
        /// </summary>
        [DataMember(Name = "tab-stop")]
        public string TabStop { get; set; }

        /// <summary>
        /// Specifies what to do with insertions, deletions, and comments produced by the MS Word “Track Changes” feature. accept (the default) processes all the insertions and deletions.
        /// </summary>
        [DataMember(Name = "track-changes")]
        public string TrackChanges { get; set; }

        /// <summary>
        /// Extract images and other media contained in or linked from the source document to the path DIR, creating it if necessary, and adjust the images references in the document so they point to the extracted files.
        /// </summary>
        [DataMember(Name = "extract-media")]
        public string ExtractMedia { get; set; }

        /// <summary>
        /// Specifies a custom abbreviations file, with abbreviations one to a line.If this option is not specified, pandoc will read the data file abbreviations from the user data directory or fall back on a system default. To see the system default, use pandoc --print-default-data-file= abbreviations.The only use pandoc makes of this list is in the Markdown reader.Strings found in this list will be followed by a nonbreaking space, and the period will not produce sentence-ending space in formats like LaTeX.The strings may not contain spaces.
        /// </summary>
        [DataMember(Name = "abbreviations")]
        public string Abbreviations { get; set; }

        /// <summary>
        /// Print diagnostic output tracing parser progress to stderr.This option is intended for use by developers in diagnosing performance issues.
        /// </summary>
        [DataMember(Name = "tracee")]
        public bool Trace { get; set; }
    }
}
