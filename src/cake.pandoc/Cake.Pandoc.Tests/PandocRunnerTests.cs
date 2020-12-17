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
    using Cake.Testing;
    using NUnit.Framework;

    [TestFixture]
    [TestOf(typeof(PandocRunner))]
    public class PandocRunnerTests
    {
        [Test]
        public void Should_Throw_If_Settings_Are_Null()
        {
            var fixture = new PandocRunnerFixture { Settings = null };

            Action result = () => fixture.Run();

            Assert.That(result, Throws.ArgumentNullException.With.Message.Contains("message"));
        }

        [Test]
        public void Should_Throw_If_Pandoc_Executable_Was_Not_Found()
        {
            var fixture = new PandocRunnerFixture();
            fixture.GivenDefaultToolDoNotExist();
            const string expectedMessage = "Pandoc: Could not locate executable";

            Action result = () => fixture.Run();

            Assert.That(result, Throws.TypeOf<CakeException>().With.Message.EqualTo(expectedMessage));
        }

        [Test]
        public void Need_More_Unit_Test_Implementations()
        {
            Assert.That(false, Is.True, "More unit tests need to be implemented for the runner class");
        }
    }
}
