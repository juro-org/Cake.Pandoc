// https://pandoc.org/MANUAL.html#general-options

namespace Cake.Pandoc
{
    using Cake.Core.IO;
    using System.Runtime.Serialization;

    public partial class PandocSettings
    {
        /// <summary>
        /// Process the citations in the file, replacing them with rendered citations and adding a bibliography.Citation processing will not take place unless bibliographic data is supplied, either through an external file specified using the --bibliography option or the bibliography field in metadata, or via a references section in metadata containing a list of citations in CSL YAML format with Markdown formatting.The style is controlled by a CSL stylesheet specified using the --csl option or the csl field in metadata. (If no stylesheet is specified, the chicago-author-date style will be used by default.) The citation processing transformation may be applied before or after filters or Lua filters(see --filter, --lua-filter): these transformations are applied in the order they appear on the command line.For more information, see the section on Citations.
        /// </summary>
        [DataMember(Name = "citeproc")]
        public bool CitationProcessing { get; set; }

        /// <summary>
        /// Set the bibliography field in the document’s metadata to FILE, overriding any value set in the metadata. If you supply this argument multiple times, each FILE will be added to bibliography.If FILE is a URL, it will be fetched via HTTP. If FILE is not found relative to the working directory, it will be sought in the resource path (see --resource-path).
        /// </summary>
        [DataMember(Name = "bibliography")]
        public FilePath Bibliography { get; set; }

        /// <summary>
        /// Set the csl field in the document’s metadata to FILE, overriding any value set in the metadata. (This is equivalent to --metadata csl = FILE.) If FILE is a URL, it will be fetched via HTTP.If FILE is not found relative to the working directory, it will be sought in the resource path(see --resource-path) and finally in the csl subdirectory of the pandoc user data directory.
        /// </summary>
        [DataMember(Name = "csl")]
        public FilePath Csl { get; set; }

        /// <summary>
        /// Set the citation-abbreviations field in the document’s metadata to FILE, overriding any value set in the metadata. (This is equivalent to --metadata citation-abbreviations= FILE.) If FILE is a URL, it will be fetched via HTTP.If FILE is not found relative to the working directory, it will be sought in the resource path(see --resource-path) and finally in the csl subdirectory of the pandoc user data directory.
        /// </summary>
        [DataMember(Name = "citation-abbreviations")]
        public FilePath CitationAbbreviations { get; set; }

        /// <summary>
        /// Use natbib for citations in LaTeX output.This option is not for use with the --citeproc option or with PDF output. It is intended for use in producing a LaTeX file that can be processed with bibtex.
        /// </summary>
        [DataMember(Name = "natbib")]
        public bool Natbib { get; set; }

        /// <summary>
        /// Use biblatex for citations in LaTeX output. This option is not for use with the --citeproc option or with PDF output. It is intended for use in producing a LaTeX file that can be processed with bibtex or biber.
        /// </summary>
        [DataMember(Name = "biblatex")]
        public bool BibLaTeX { get; set; }
    }
}
