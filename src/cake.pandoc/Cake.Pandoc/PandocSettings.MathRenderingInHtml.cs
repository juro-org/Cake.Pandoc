using System.Runtime.Serialization;

// https://pandoc.org/MANUAL.html#math-rendering-in-html

namespace Cake.Pandoc
{
    public partial class PandocSettings
    {
        /// <summary>
        /// Use MathJax to display embedded TeX math in HTML output.TeX math will be put between \(...\) (for inline math) or \[...\] (for display math) and wrapped in <span> tags with class math. Then the MathJax JavaScript will render it.The URL should point to the MathJax.js load script.If a URL is not provided, a link to the Cloudflare CDN will be inserted.
        /// </summary>
        /// <value>
        /// The mathjax.
        /// </value>
        [DataMember(Name = "mathjax")]
        public string Mathjax { get; set; }

        /// <summary>
        /// Convert TeX math to MathML (in epub3, docbook4, docbook5, jats, html4 and html5). This is the default in odt output.Note that currently only Firefox and Safari (and select e-book readers) natively support MathML.
        /// </summary>
        ///
        [DataMember(Name = "mathml")]
        public bool MathMl { get; set; }

        /// <summary>
        /// Convert TeX formulas to<img> tags that link to an external script that converts formulas to images.The formula will be URL-encoded and concatenated with the URL provided.For SVG images you can for example use --webtex https://latex.codecogs.com/svg.latex?. If no URL is specified, the CodeCogs URL generating PNGs will be used (https://latex.codecogs.com/png.latex?). Note: the --webtex option will affect Markdown output as well as HTML, which is useful if you’re targeting a version of Markdown without native math support.
        /// </summary>
        [DataMember(Name = "webtex")]
        public string WebTeX { get; set; }

        /// <summary>
        /// Use KaTeX to display embedded TeX math in HTML output.The URL is the base URL for the KaTeX library.That directory should contain a katex.min.js and a katex.min.css file. If a URL is not provided, a link to the KaTeX CDN will be inserted.
        /// </summary>
        [DataMember(Name = "katex")]
        public string KaTeX { get; set; }

        /// <summary>
        /// Enclose TeX math in <eq> tags in HTML output. The resulting HTML can then be processed by GladTeX to produce SVG images of the typeset formulas and an HTML file with these images embedded.
        /// </summary>
        [DataMember(Name = "gladtex")]
        public bool GladTeX { get; set; }
    }
}
