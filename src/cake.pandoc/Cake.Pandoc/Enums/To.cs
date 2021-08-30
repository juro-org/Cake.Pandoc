namespace Cake.Pandoc.Enums
{
    public class To : EnumBaseType
    {
        /// <summary>
        /// (AsciiDoc) or asciidoctor (AsciiDoctor).
        /// </summary>
        public static readonly To AsciiDoc = new To("asciidoc");

        /// <summary>
        /// (LaTeX beamer slide show).
        /// </summary>
        public static readonly To Beamer = new To("beamer");

        /// <summary>
        /// CommonMark Markdown.
        /// </summary>
        public static readonly To Commonmark = new To("commonmark");

        /// <summary>
        /// CommonMark Markdown with extensions.
        /// </summary>
        public static readonly To CommonmarkWithExtensions = new To("commonmark_x");

        /// <summary>
        /// (ConTeXt).
        /// </summary>
        public static readonly To ConTeXt = new To("context");

        /// <summary>
        /// DocBook.
        /// </summary>
        public static readonly To DocBook = new To("docbook");

        /// <summary>
        /// (DocBook 5).
        /// </summary>
        public static readonly To DocBook5 = new To("docbook5");

        /// <summary>
        /// Word docx.
        /// </summary>
        public static readonly To Docx = new To("docx");

        /// <summary>
        /// DokuWiki markup.
        /// </summary>
        public static readonly To DokuWiki = new To("dokuwiki");

        /// <summary>
        /// EPUB.
        /// </summary>
        public static readonly To Epub = new To("epub");

        /// <summary>
        /// (EPUB v2).
        /// </summary>
        public static readonly To Epub2 = new To("epub2");

        /// <summary>
        /// FictionBook2 e-book.
        /// </summary>
        public static readonly To FictionBook2 = new To("fb2");

        /// <summary>
        /// GitHub-Flavored Markdown), or the deprecated and less accurate markdown_github; use markdown_github only if you need extensions not supported in gfm.
        /// </summary>
        public static readonly To GitHubFlavoredMarkdown = new To("gfm");

        /// <summary>
        /// Haddock markup.
        /// </summary>
        public static readonly To Haddock = new To("haddock");

        /// <summary>
        /// HTML.
        /// </summary>
        public static readonly To Html = new To("html");

        /// <summary>
        /// (XHTML 1.0 Transitional).
        /// </summary>
        public static readonly To Html4 = new To("html4");

        /// <summary>
        /// (InDesign ICML).
        /// </summary>
        public static readonly To Icml = new To("icml");

        /// <summary>
        /// Jupyter notebook.
        /// </summary>
        public static readonly To JupyterNotebook = new To("ipynb");

        /// <summary>
        /// (JATS XML, Archiving and Interchange Tag Set).
        /// </summary>
        public static readonly To JatsArchiving = new To("jats_archiving");

        /// <summary>
        /// (JATS XML, Article Authoring Tag Set).
        /// </summary>
        public static readonly To JatsArticleAuthoring = new To("jats_articleauthoring");

        /// <summary>
        /// (JATS XML, Journal Publishing Tag Set).
        /// </summary>
        public static readonly To JatsPublishing = new To("jats_publishing");

        /// <summary>
        /// JATS XML.
        /// </summary>
        public static readonly To Jats = new To("jats");

        /// <summary>
        /// Jira/Confluence wiki markup.
        /// </summary>
        public static readonly To Jira = new To("jira");

        /// <summary>
        /// JSON version of native AST.
        /// </summary>
        public static readonly To Json = new To("json");

        /// <summary>
        /// LaTeX.
        /// </summary>
        public static readonly To Latex = new To("latex");

        /// <summary>
        /// roff man.
        /// </summary>
        public static readonly To Man = new To("man");

        /// <summary>
        /// Pandoc’s Markdown.
        /// </summary>
        public static readonly To Markdown = new To("markdown");

        /// <summary>
        /// MultiMarkdown.
        /// </summary>
        public static readonly To MultiMarkdown = new To("markdown_mmd");

        /// <summary>
        /// PHP Markdown Extra.
        /// </summary>
        public static readonly To PhpExtraMarkdown = new To("markdown_phpextra");

        /// <summary>
        /// original unextended Markdown.
        /// </summary>
        public static readonly To StrictMarkdown = new To("markdown_strict");

        /// <summary>
        /// MediaWiki markup.
        /// </summary>
        public static readonly To MediaWiki = new To("mediawiki");

        /// <summary>
        /// (roff ms).
        /// </summary>
        public static readonly To Ms = new To("ms");

        /// <summary>
        /// Muse.
        /// </summary>
        public static readonly To Muse = new To("muse");

        /// <summary>
        /// native Haskell.
        /// </summary>
        public static readonly To Native = new To("native");

        /// <summary>
        /// ODT.
        /// </summary>
        public static readonly To Odt = new To("odt");

        /// <summary>
        /// OPML.
        /// </summary>
        public static readonly To Opml = new To("opml");

        /// <summary>
        /// (OpenDocument).
        /// </summary>
        public static readonly To OpenDocument = new To("opendocument");

        /// <summary>
        /// Emacs Org mode.
        /// </summary>
        public static readonly To Org = new To("org");

        /// <summary>
        /// (PDF).
        /// </summary>
        public static readonly To Pdf = new To("pdf");

        /// <summary>
        /// (plain text),.
        /// </summary>
        public static readonly To Plain = new To("plain");

        /// <summary>
        /// (PowerPoint slide show).
        /// </summary>
        public static readonly To Pptx = new To("pptx");

        /// <summary>
        /// reStructuredText.
        /// </summary>
        public static readonly To ReStructuredText = new To("rst");

        /// <summary>
        /// (Rich Text Format).
        /// </summary>
        public static readonly To Rtf = new To("rtf");

        /// <summary>
        /// (GNU Texinfo).
        /// </summary>
        public static readonly To Texinfo = new To("texinfo");

        /// <summary>
        /// Textile.
        /// </summary>
        public static readonly To Textile = new To("textile");

        /// <summary>
        /// (Slideous HTML and JavaScript slide show).
        /// </summary>
        public static readonly To Slideous = new To("slideous");

        /// <summary>
        /// (Slidy HTML and JavaScript slide show).
        /// </summary>
        public static readonly To Slidy = new To("slidy");

        /// <summary>
        /// (DZSlides HTML5 + JavaScript slide show),.
        /// </summary>
        public static readonly To DZSlides = new To("dzslides");

        /// <summary>
        /// (reveal.js HTML5 + JavaScript slide show).
        /// </summary>
        public static readonly To Revealjs = new To("revealjs");

        /// <summary>
        /// (S5 HTML and JavaScript slide show).
        /// </summary>
        public static readonly To S5 = new To("s5");

        /// <summary>
        /// (TEI Simple).
        /// </summary>
        public static readonly To Tei = new To("tei");

        /// <summary>
        /// (XWiki markup).
        /// </summary>
        public static readonly To XWiki = new To("xwiki");

        /// <summary>
        /// (ZimWiki markup).
        /// </summary>
        public static readonly To ZimWiki = new To("zimwiki");

        private To(string value)
            : base(value)
        {
        }
    }
}
