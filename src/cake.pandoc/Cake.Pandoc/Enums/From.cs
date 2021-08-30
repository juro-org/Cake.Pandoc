namespace Cake.Pandoc.Enums
{
    public class From : EnumBaseType
    {
        /// <summary>
        /// CommonMark Markdown.
        /// </summary>
        public static readonly From Commonmark = new From("commonmark");

        /// <summary>
        /// CommonMark Markdown with extensions.
        /// </summary>
        public static readonly From CommonmarkWithExtensions = new From("commonmark_x");

        /// <summary>
        /// Creole 1.0.
        /// </summary>
        public static readonly From Creole = new From("creole");

        /// <summary>
        /// CSV table.
        /// </summary>
        public static readonly From Csv = new From("csv");

        /// <summary>
        /// DocBook.
        /// </summary>
        public static readonly From DocBook = new From("docbook");

        /// <summary>
        /// Word docx.
        /// </summary>
        public static readonly From Docx = new From("docx");

        /// <summary>
        /// DokuWiki markup.
        /// </summary>
        public static readonly From DokuWiki = new From("dokuwiki");

        /// <summary>
        /// EPUB.
        /// </summary>
        public static readonly From Epub = new From("epub");

        /// <summary>
        /// FictionBook2 e-book.
        /// </summary>
        public static readonly From FictionBook2 = new From("fb2");

        /// <summary>
        /// GitHub-Flavored Markdown), or the deprecated and less accurate markdown_github; use markdown_github only if you need extensions not supported in gfm.
        /// </summary>
        public static readonly From GitHubFlavoredMarkdown = new From("gfm");

        /// <summary>
        /// Haddock markup.
        /// </summary>
        public static readonly From Haddock = new From("haddock");

        /// <summary>
        /// HTML.
        /// </summary>
        public static readonly From Html = new From("html");

        /// <summary>
        /// Jupyter notebook.
        /// </summary>
        public static readonly From JupyterNotebook = new From("ipynb");

        /// <summary>
        /// JATS XML.
        /// </summary>
        public static readonly From Jats = new From("jats");

        /// <summary>
        /// Jira/Confluence wiki markup.
        /// </summary>
        public static readonly From Jira = new From("jira");

        /// <summary>
        /// JSON version of native AST.
        /// </summary>
        public static readonly From Json = new From("json");

        /// <summary>
        /// LaTeX.
        /// </summary>
        public static readonly From Latex = new From("latex");

        /// <summary>
        /// Pandoc’s Markdown.
        /// </summary>
        public static readonly From Markdown = new From("markdown");

        /// <summary>
        /// MultiMarkdown.
        /// </summary>
        public static readonly From MultiMarkdown = new From("markdown_mmd");

        /// <summary>
        /// PHP Markdown Extra.
        /// </summary>
        public static readonly From PhpExtraMarkdown = new From("markdown_phpextra");

        /// <summary>
        /// original unextended Markdown.
        /// </summary>
        public static readonly From StrictMarkdown = new From("markdown_strict");

        /// <summary>
        /// MediaWiki markup.
        /// </summary>
        public static readonly From MediaWiki = new From("mediawiki");

        /// <summary>
        /// roff man.
        /// </summary>
        public static readonly From Man = new From("man");

        /// <summary>
        /// Muse.
        /// </summary>
        public static readonly From Muse = new From("muse");

        /// <summary>
        /// native Haskell.
        /// </summary>
        public static readonly From Native = new From("native");

        /// <summary>
        /// ODT.
        /// </summary>
        public static readonly From Odt = new From("odt");

        /// <summary>
        /// OPML.
        /// </summary>
        public static readonly From Opml = new From("opml");

        /// <summary>
        /// Emacs Org mode.
        /// </summary>
        public static readonly From Org = new From("org");

        /// <summary>
        /// reStructuredText.
        /// </summary>
        public static readonly From ReStructuredText = new From("rst");

        /// <summary>
        /// txt2tags.
        /// </summary>
        public static readonly From Txt2tags = new From("t2t");

        /// <summary>
        /// Textile.
        /// </summary>
        public static readonly From Textile = new From("textile");

        /// <summary>
        /// TikiWiki markup.
        /// </summary>
        public static readonly From TikiWiki = new From("tikiwiki");

        /// <summary>
        /// TWiki markup.
        /// </summary>
        public static readonly From TWiki = new From("twiki");

        /// <summary>
        /// Vimwiki.
        /// </summary>
        public static readonly From Vimwiki = new From("vimwik");

        private From(string value)
            : base(value)
        {
        }
    }
}
