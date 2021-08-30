/*
 * MIT License
 *
 * Copyright (c) 2020 Jürgen Rosenthal-Buroh
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

namespace Cake.Pandoc.Tests
{
    using System;
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Testing;
    using NUnit.Framework;

    using Shouldly;

    [TestFixture]
    [TestOf(typeof(PandocAliases))]
    public class PandocAliasesTests
    {
        [Test]
        public void PandacInit_JustCallPandoc()
        {
            var fixture = new PandocAliasesFixture();

            fixture.Settings = null;
            var actual = fixture.Run();

            actual.Args.ShouldBe("");
        }

        [Test]
        public void PandacWithSettings_UsePassedSettings()
        {
            var fixture = new PandocAliasesFixture();

            fixture.Settings = new PandocSettings()
            {
                From = Enums.From.Commonmark,
                To = Enums.To.AsciiDoc,
                FailIfWarnings = true
            };
            var actual = fixture.Run();

            actual.Args.ShouldContain("--from=commonmark");
            actual.Args.ShouldContain("--to=asciidoc");
            actual.Args.ShouldContain("--fail-if-warnings");
        }
    }
}
