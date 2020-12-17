namespace Cake.Pandoc.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Testing;
    using NUnit.Framework;

    [TestFixture]
    [TestOf(typeof(PandocSettings))]
    public class PandocSettingsTests
    {
        //DLL Reference in cake => #r oder so
        internal static IEnumerable<(Action<PandocSettings>, string)> Data
        {
            get
            {
                yield return (s => { s.Files.Add("/File1.txt"); s.Files.Add("/File2.txt"); }, "\"/File1.txt\" \"/File2.txt\"");
                yield return (s => { s.Files.Add(new FilePath("/File1.txt")); s.Files.Add(new FilePath("/File2.txt")); }, "\"/File1.txt\" \"/File2.txt\"");
                yield return (s => s.From = Enums.From.Commonmark, "--from=commonmark");
                yield return (s => s.To = Enums.To.AsciiDoc, "--to=asciidoc");
                yield return (s => s.Output = new FilePath("/File.txt"), "--output=\"/File.txt\"");
                yield return (s => s.Output = "/FILE", "--output=\"/FILE\"");
                yield return (s => s.DataDirectory = new DirectoryPath("/foo"), "--data-dir=\"/foo\"");
                yield return (s => s.DataDirectory ="/foo", "--data-dir=\"/foo\"");
                yield return (s => s.Defaults = new FilePath("/FILE.yml"), "--defaults=\"/FILE.yml\"");
                yield return (s => s.Defaults = "/FILE.yml", "--defaults=\"/FILE.yml\"");
                yield return (s => s.BashCompletion = true, "--bash-completion");
                yield return (s => s.Verbose = true, "--verbose");
                yield return (s => s.Quiet = true, "--quiet");
                yield return (s => s.FailIfWarnings = true, "--fail-if-warnings");
                yield return (s => s.ListInputFormats = true, "--list-input-formats");
                yield return (s => s.ListOutputFormats = true, "--list-output-formats");
                yield return (s => s.ListHighlightLanguages = true, "--list-highlight-languages");
                yield return (s => s.ListHighlightStyles = true, "--list-highlight-styles");
                yield return (s => s.Version = true, "--version");
                yield return (s => s.Help = true, "--help");
            }
        }

        public static IEnumerator<object[]> TestData
        {
            get
            {
                return Data.Select(x => new[] { (object)x.Item1, x.Item2 }).GetEnumerator();
            }
        }


        [Test, TestCaseSource(nameof(TestData))]
        public void Test_all_setters(Action<PandocSettings> arrange, string expected)
        {
            var builder = new ProcessArgumentBuilder();
            var environment = FakeEnvironment.CreateWindowsEnvironment();
            var settings = new PandocSettings();

            arrange(settings);

            settings.Evaluate(builder, environment);
            var actual = builder.Render();
            Assert.AreEqual(expected, actual);
        }
    }
}
