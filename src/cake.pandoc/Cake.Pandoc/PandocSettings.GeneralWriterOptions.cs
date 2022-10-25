using System;
using System.Collections.Generic;
using System.Text;


// https://pandoc.org/MANUAL.html#general-writer-options

namespace Cake.Pandoc
{
    public partial class PandocSettings
    {
        /// <summary>
        /// Produce output with an appropriate header and footer(e.g.a standalone HTML, LaTeX, TEI, or RTF file, not a fragment).
        /// </summary>
        [DataMember(Name = "standalone")]
        public bool Standalone { get; set; }

        /// <summary>
        /// Use the specified file as a custom template for the generated document.
        /// </summary>
        [DataMember(Name = "template")]
        public string Template { get; set; }

        /// <summary>
        /// Set the template variable KEY to the value VAL when rendering the document in standalone mode. If no VAL is specified, the key will be given the value true.
        /// </summary>
        [DataMember(Name = "variable")]
        public string Variable { get; set; }

        /// <summary>
        /// Run pandoc in a sandbox, limiting IO operations in readers and writers to reading the files specified on the command line
        /// </summary>
        [DataMember(Name = "sandbox")]
        public bool Sandbox { get; set; }

        /// <summary>
        /// Print the system default template for an output FORMAT. (See -t for a list of possible FORMATs.)
        /// </summary>
        [DataMember(Name = "print-default-template")]
        public string PrintDefaultTemplate { get; set; }


        /// <summary>
        /// Manually specify line endings: crlf (Windows), lf (macOS/Linux/UNIX), or native(line endings appropriate to the OS on which pandoc is being run). The default is native.
        /// </summary>
        [DataMember(Name = "eol")]
        public Enums.EndOfLine Eol { get; set; }

        /// <summary>
        /// Specify the default dpi(dots per inch) value for conversion from pixels to inch/centimeters and vice versa. (Technically, the correct term would be ppi: pixels per inch.) The default is 96dpi.When images contain information about dpi internally, the encoded value is used instead of the default specified by this option.
        /// </summary>
        [DataMember(Name = "dpi")]
        public string Dpi { get; set; }

        /// <summary>
        /// Determine how text is wrapped in the output (the source code, not the rendered version). With auto (the default), pandoc will attempt to wrap lines to the column width specified by --columns (default 72). With none, pandoc will not wrap lines at all. With preserve, pandoc will attempt to preserve the wrapping from the source document (that is, where there are nonsemantic newlines in the source, there will be nonsemantic newlines in the output as well). In ipynb output, this option affects wrapping of the contents of markdown cells.
        /// </summary>
        /// --wrap= auto | none | preserve
        [DataMember(Name = "wrap")]
        public string Wrap { get; set; }

        /// <summary>
        /// Specify length of lines in characters. This affects text wrapping in the generated source code (see --wrap). It also affects calculation of column widths for plain text tables (see Tables below).
        /// </summary>
        [DataMember(Name = "columns")]
        public string Columns { get; set; }

        /// <summary>
        /// Include an automatically generated table of contents (or, in the case of latex, context, docx, odt, opendocument, rst, or ms, an instruction to create one) in the output document. This option has no effect unless -s/--standalone is used, and it has no effect on man, docbook4, docbook5, or jats output.
        /// </summary>
        [DataMember(Name = "table-of-contentse")]
        public bool Toc { get; set; }

        /// <summary>
        /// Specify the number of section levels to include in the table of contents. The default is 3 (which means that level-1, 2, and 3 headings will be listed in the contents).
        /// </summary>
        [DataMember(Name = "toc-depth")]
        public string TocDepth { get; set; }

        /// <summary>
        /// Strip out HTML comments in the Markdown or Textile source, rather than passing them on to Markdown, Textile or HTML output as raw HTML. This does not apply to HTML comments inside raw HTML blocks when the markdown_in_html_blocks extension is not set.
        /// </summary>
        [DataMember(Name = "strip-comments")]
        public string StripComments { get; set; }

        /// <summary>
        /// Disables syntax highlighting for code blocks and inlines, even when a language attribute is given
        /// </summary>
        [DataMember(Name = "no-highlight")]
        public bool NoHighlight { get; set; }

        /// <summary>
        /// Specifies the coloring style to be used in highlighted source code.Options are pygments(the default), kate, monochrome, breezeDark, espresso, zenburn, haddock, and tango.For more information on syntax highlighting in pandoc, see Syntax highlighting, below.See also--list - highlight - styles.
        /// </summary>
        [DataMember(Name = "highlight-style")]
        public string Highlight-Style { get; set; }

        /// <summary>
        /// Prints a JSON version of a highlighting style, which can be modified, saved with a.theme extension, and used with --highlight - style.This option may be used with - o / --output to redirect output to a file, but -o / --output must come before--print - highlight - style on the command line.
        /// </summary>
        [DataMember(Name = "print-highlight-style")]
        public string PrintHighlightStyle { get; set; }

        /// <summary>
        /// Instructs pandoc to load a KDE XML syntax definition file, which will be used for syntax highlighting of appropriately marked code blocks.This can be used to add support for new languages or to use altered syntax definitions for existing languages. This option may be repeated to add multiple syntax definitions.
        /// </summary>
        [DataMember(Name = "syntax-definition")]
        public string SyntaxDefinition { get; set; }

        /// <summary>
        /// Include contents of FILE, verbatim, at the end of the header.This can be used, for example, to include special CSS or JavaScript in HTML documents.This option can be used repeatedly to include multiple files in the header.They will be included in the order specified.Implies--standalone.
        /// </summary>
        [DataMember(Name = "include-in-header")]
        public string IncludeInHeader { get; set; }

        /// <summary>
        /// Include contents of FILE, verbatim, at the beginning of the document body(e.g.after the < body > tag in HTML, or the \begin{ document}
        ///    command in LaTeX). This can be used to include navigation bars or banners in HTML documents.This option can be used repeatedly to include multiple files.They will be included in the order specified.Implies--standalone.
        /// </summary>
        [DataMember(Name = "include-before-body")]
        public string IncludeBeforeBody { get; set; }

        /// <summary>
        /// Include contents of FILE, verbatim, at the end of the document body(before the </ body > tag in HTML, or the \end{ document}
        ///  command in LaTeX). This option can be used repeatedly to include multiple files.They will be included in the order specified.Implies--standalone.
        /// </summary>
        [DataMember(Name = "include-after-body")]
        public string IncludeAfterBody { get; set; }

        /// <summary>
        /// List of paths to search for images and other resources.The paths should be separated by : on Linux, UNIX, and macOS systems, and by ; on Windows. If--resource - path is not specified, the default resource path is the working directory.Note that, if --resource - path is specified, the working directory must be explicitly listed or it will not be searched.For example: --resource - path =.:test will search the working directory and the test subdirectory, in that order. This option can be used repeatedly. Search path components that come later on the command line will be searched before those that come earlier, so --resource - path foo: bar--resource - path baz: bim is equivalent to --resource - path baz: bim: foo: bar.
        /// </summary>
        [DataMember(Name = "resource-path")]
        public string ResourcePath { get; set }

        /// <summary>
        /// Set the request header NAME to the value VAL when making HTTP requests(for example, when a URL is given on the command line, or when resources used in a document must be downloaded).If you’re behind a proxy, you also need to set the environment variable http_proxy to http://....
        /// </summary>
        [DataMember(Name = "request-header")]
        public string RequestHeader { get; set; }

        /// <summary>
        /// Disable the certificate verification to allow access to unsecure HTTP resources(for example when the certificate is no longer valid or self signed).
        /// </summary>
        [DataMember(Name = "no-check-certificate")]
        public bool NoCheckCertificate { get; set; }

    }
}
