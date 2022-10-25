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

// https://pandoc.org/MANUAL.html#options-for-wrapper-scripts

namespace Cake.Pandoc
{
    using System.Runtime.Serialization;

    public partial class PandocSettings
    {
        /// <summary>
        /// Print information about command-line arguments to stdout, then exit.
        /// </summary>
        [DataMember(Name = "dump-args")]
        public bool DumpArgs { get; set; }

        /// <summary>
        /// Ignore command-line arguments.
        /// </summary>
        [DataMember(Name = "ignore-args")]
        public bool IgnoreArgs { get; set; }
    }
}
